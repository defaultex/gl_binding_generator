namespace glregistry;

class Program {
    static readonly XmlSerializer Serializer = new XmlSerializer(typeof(GLRegistry));

    // args = { gl|gles1|gles2|glsc2, core|compatibility }
    static void Main(string[] args) {
        string strTargetAPI = null;
        GLAPI targetAPI = GLAPI.None;
        GLAPI extensionAPI = GLAPI.None;
        GLProfile targetProfile = GLProfile.None;
        if (args != null && args.Length > 2) {
            strTargetAPI = args[0];

            if (args[0] == "gl") {
                targetAPI = GLAPI.GL;
            } else if (args[0] == "glcore") {
                targetAPI = GLAPI.GLCore;
            } else if (args[0] == "gles1") {
                targetAPI = GLAPI.GLES1;
            } else if (args[0] == "gles2") {
                targetAPI = GLAPI.GLES2;
            } else if (args[0] == "glsc2") {
                targetAPI = GLAPI.GLSC2;
            }

            if (args[1] == "core") {
                targetProfile = GLProfile.Core;
            } else if (args[1] == "compatibility") {
                targetProfile = GLProfile.Compatibility;
            }

            if (args[2] == "gl") {
                extensionAPI = GLAPI.GL;
            } else if (args[2] == "glcore") {
                extensionAPI = GLAPI.GLCore;
            } else if (args[2] == "gles1") {
                extensionAPI = GLAPI.GLES1;
            } else if (args[2] == "gles2") {
                extensionAPI = GLAPI.GLES2;
            } else if (args[2] == "glsc2") {
                extensionAPI = GLAPI.GLSC2;
            }
        } else {
            Console.WriteLine("No api and/or profile selected. Unable to proceed.");
            Console.WriteLine("Valid format is: glregistry api profile extension_api");
            Console.WriteLine("Valid arguments for api are: gl, gles1, and gles2.");
            Console.WriteLine("Valid arguments for profile are: core, and compatibility.");
            Console.WriteLine("Valid arguments for extension_api are: gl, glcore, gles1, gles2, and common.");
            return;
        }

        GLRegistry registry;

        Stopwatch swDeserialize = Stopwatch.StartNew();
        using (XmlReader reader = new XmlTextReader(Resources.XmlFilename)) {
            registry = Serializer.Deserialize(reader) as GLRegistry;
        }
        swDeserialize.Stop();
        Console.WriteLine("Deserialized XML in {0}ms", swDeserialize.ElapsedMilliseconds);

        Stopwatch swPrepping = Stopwatch.StartNew();
        registry.Initialize();

        List<OutputFile> outputFiles = new();
        ExtractFeatures(registry, outputFiles, targetAPI, targetProfile);
        ExtractExtensions(registry, outputFiles, extensionAPI, targetProfile);

        List<string> typeList = new();
        List<string> classList = new();
        List<GLGroup> groupList = new();
        foreach (OutputFile file in outputFiles) {
            file.TrimLists();

            foreach (GLEnum enumerant in file.Enums) {
                if (!enumerant.Required) {
                    continue;
                }

                string groupNames = enumerant.Groups;
                if (string.IsNullOrEmpty(groupNames)) {
                    continue;
                }

                string[] groups = groupNames.Split(',');
                foreach (string groupName in groups) {
                    if (Resources.IsGroupBlacklisted(groupName)) {
                        continue;
                    }

                    string newGroupName = Resources.GetGroupName(groupName);
                    GLGroup group = groupList.Find(newGroupName);
                    if (group == null) {
                        group = new() {
                            Name = newGroupName,
                            Type = newGroupName.EndsWith("Mask") ? "GLbitfield" : "GLenum",
                            API = targetAPI,
                            Required = Resources.AlwaysRequire.Contains(groupName)
                        };
                        groupList.Add(group);
                    }

                    if (!file.Groups.Contains(group)) {
                        file.Groups.Add(group);
                    }

                    if (!group.Enums.Contains(enumerant)) {
                        enumerant.SourceName = (file.Extension != null) ? file.Extension.Name : null;
                        group.Enums.Add(enumerant);
                    }
                }
            }

            foreach (GLCommand command in file.Commands) {
                if (!command.Required) {
                    continue;
                }

                string cmdType = command.Prototype.Type;
                string cmdClass = command.Prototype.Class;
                string cmdGroup = command.Prototype.Group;

                if (!string.IsNullOrEmpty(cmdType) && !typeList.Contains(cmdType)) {
                    typeList.Add(cmdType);
                }

                if (!string.IsNullOrEmpty(cmdClass) && !classList.Contains(cmdClass)) {
                    classList.Add(cmdClass);
                }

                if (!string.IsNullOrEmpty(cmdGroup) && !Resources.IsGroupBlacklisted(cmdGroup)) {
                    string newGroupName = Resources.GetGroupName(cmdGroup);
                    GLGroup group = groupList.Find(newGroupName);
                    if (group != null) {
                        group.Required |= command.Required;
                    }
                }

                foreach (GLPrototype param in command.Parameters) {
                    string paramType = param.Type;
                    string paramClass = param.Class;
                    string paramGroup = param.Group;

                    if (!string.IsNullOrEmpty(paramType) && !typeList.Contains(paramType)) {
                        typeList.Add(paramType);
                    }

                    if (!string.IsNullOrEmpty(paramClass) && !classList.Contains(paramClass)) {
                        classList.Add(paramClass);
                    }

                    if (!string.IsNullOrEmpty(paramGroup) && !Resources.IsGroupBlacklisted(paramGroup)) {
                        string newGroupName = Resources.GetGroupName(paramGroup);
                        GLGroup group = groupList.Find(newGroupName);
                        if (group != null) {
                            group.Required |= command.Required;
                        }
                    }
                }
            }

            file.Commands.Sort(Resources.CompareCommands);
            file.Enums.Sort(Resources.CompareEnumerants);
            file.Groups.Sort(Resources.CompareGroups);
        }

        groupList.Sort(Resources.CompareGroups);
        outputFiles.UpdateCode();

        swPrepping.Stop();
        Console.WriteLine("Prepared registry for writing in {0}ms.", swPrepping.ElapsedMilliseconds);

        Stopwatch swWriting = Stopwatch.StartNew();

        // regenerate the output directory then write all the files based on the above filters
        if (Directory.Exists(Resources.OutputFolder)) {
            Directory.Delete(Resources.OutputFolder, true);
            Console.WriteLine("Deleted directory: {0}", Resources.OutputFolder);
        }

        Directory.CreateDirectory(Resources.OutputFolder);
        Console.WriteLine("Created directory: {0}", Resources.OutputFolder);

        WriteGitignore();
        WriteCSProj();
        WriteUsings(typeList);
        WriteClasses(classList);

        for (int i = 0; i < outputFiles.Count; i++) {
            OutputFile file = outputFiles[i];
            string name = file.Name;
            if (string.IsNullOrEmpty(name)) {
                return;
            }

            string folderPath = null;
            if (file.Feature != null) {
                folderPath = string.Format(Resources.FeatureFolder, name);
            } else if (file.Extension != null) {
                folderPath = string.Format(Resources.ExtensionFolder, name);
            }

            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Created directory: {0}", folderPath);
            }

            WriteConstants(file, folderPath, strTargetAPI);
            WriteCommands(file, folderPath, strTargetAPI);
            WriteEnums(file, folderPath, groupList);
        }

        swWriting.Stop();
        Console.WriteLine("All files written in {0}ms.", swWriting.ElapsedMilliseconds);
        Console.WriteLine("Completed in {0}s.", swDeserialize.Elapsed.TotalSeconds + swPrepping.Elapsed.TotalSeconds + swWriting.Elapsed.TotalSeconds);
    }

    static void ExtractFeatures(GLRegistry registry, List<OutputFile> outputFiles, GLAPI api, GLProfile profile) {
        foreach (GLFeature feature in registry.Features) {
            if ((feature.API & api) == GLAPI.None) {
                continue;
            }

            OutputFile file = new() { Feature = feature };
            outputFiles.Add(file);

            foreach (GLDepends depends in feature.Require) {
                if ((depends.API != GLAPI.None && (depends.API & api) == GLAPI.None) ||
                    (depends.Profile != GLProfile.None && (depends.Profile & profile) == GLProfile.None)) {
                    continue;
                }

                foreach (GLAlias enumAlias in depends.Enumerants) {
                    GLEnum enumerant = registry.Enums.Find(enumAlias.Name);
                    if (enumerant != null) {
                        enumerant.Required = true;
                        file.Enums.Add(enumerant);
                    }
                }

                foreach (GLAlias cmdAlias in depends.Commands) {
                    GLCommand command = registry.Commands.Find(cmdAlias.Name);
                    if (command != null) {
                        command.Required = true;
                        file.Commands.Add(command);
                    }
                }
            }

            foreach (GLDepends depends in feature.Remove) {
                if ((depends.API != GLAPI.None && (depends.API & api) == GLAPI.None) ||
                    (depends.Profile != GLProfile.None && (depends.Profile & profile) == GLProfile.None)) {
                    continue;
                }

                foreach (GLAlias enumAlias in depends.Enumerants) {
                    GLEnum enumerant = registry.Enums.Find(enumAlias.Name);
                    if (enumerant != null) {
                        enumerant.Required = false;
                    }
                }

                foreach (GLAlias cmdAlias in depends.Commands) {
                    GLCommand command = registry.Commands.Find(cmdAlias.Name);
                    if (command != null) {
                        command.Required = false;
                    }
                }
            }
        }
    }

    static void ExtractExtensions(GLRegistry registry, List<OutputFile> outputFiles, GLAPI api, GLProfile profile) {
        foreach (GLExtension extension in registry.Extensions) {
            if ((extension.SupportedAPIs & api) == GLAPI.None) {
                continue;
            }

            OutputFile file = new() { Extension = extension };
            outputFiles.Add(file);

            foreach (GLDepends depends in extension.Require) {
                if ((depends.API != GLAPI.None && (depends.API & api) == GLAPI.None) ||
                    (depends.Profile != GLProfile.None && (depends.Profile & profile) == GLProfile.None)) {
                    continue;
                }

                foreach (GLAlias enumAlias in depends.Enumerants) {
                    GLEnum enumerant = registry.Enums.Find(enumAlias.Name);
                    if (enumerant != null) {
                        enumerant.Required = true;
                        //enumerant.SourceName = enumerant.SourceName ?? file.Name;
                        file.Enums.Add(enumerant);
                    }
                }

                foreach (GLAlias cmdAlias in depends.Commands) {
                    GLCommand command = registry.Commands.Find(cmdAlias.Name);
                    if (command != null) {
                        command.Required = true;
                        //command.SourceName = command.SourceName ?? file.Name;
                        file.Commands.Add(command);
                    }
                }
            }

            foreach (GLDepends depends in extension.Remove) {
                if ((depends.API != GLAPI.None && (depends.API & api) == GLAPI.None) ||
                    (depends.Profile != GLProfile.None && (depends.Profile & profile) == GLProfile.None)) {
                    continue;
                }

                foreach (GLAlias enumAlias in depends.Enumerants) {
                    GLEnum enumerant = registry.Enums.Find(enumAlias.Name);
                    if (enumerant != null) {
                        enumerant.Required = false;
                    }
                }

                foreach (GLAlias cmdAlias in depends.Commands) {
                    GLCommand command = registry.Commands.Find(cmdAlias.Name);
                    if (command != null) {
                        command.Required = false;
                    }
                }
            }
        }
    }

    static void WriteConstants(OutputFile file, string folderPath, string api) {
        string name = file.Name;
        bool isExtension = (file.Extension != null);

        // write constants for each of the enumerants required by the feature or extension
        string constFilename = folderPath + string.Format(Resources.ConstantsFilename, api);
        using (FileStream stream = File.OpenWrite(constFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            if (isExtension) {
                writer.WriteLine("#if {0}\n", name);
            }
            writer.WriteLine(Resources.ConstantsHeader, api);

            for (int i = 0; i < file.Enums.Count; i++) {
                if (!file.Enums[i].Declared && file.Enums[i].Required) {
                    file.Enums[i].Declared = true;
                    writer.WriteLine(file.Enums[i].CSDecl);
                }
            }

            writer.WriteLine(Resources.ConstantsFooter);

            if (isExtension) {
                writer.Write("\n#endif");
            }
        }
        Console.WriteLine("Created file: {0}", constFilename);
    }

    static void WriteCommands(OutputFile file, string folderPath, string api) {
        string name = file.Name;
        bool isExtension = (file.Extension != null);

        // write functions for each of the commands required by the feature or extension
        string functFilename = folderPath + string.Format(Resources.FunctionsFilename, api);
        using (FileStream stream = File.OpenWrite(functFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            if (isExtension) {
                writer.WriteLine("#if {0}\n", name);
            }
            writer.WriteLine(Resources.FeatureHeader, api);

            for (int i = 0; i < file.Commands.Count; i++) {
                if (!file.Commands[i].Declared && file.Commands[i].Required) {
                    file.Commands[i].Declared = true;
                    writer.Write(Resources.FeatureFunction, file.Commands[i].CDecl, file.Commands[i].CSDecl);
                }
            }

            writer.WriteLine(Resources.FeatureFooter);

            if (isExtension) {
                writer.Write("\n#endif");
            }
        }
        Console.WriteLine("Created file: {0}", functFilename);
    }

    static void WriteEnums(OutputFile file, string folderPath, List<GLGroup> usedGroups) {
        string name = file.Name;
        bool isExtension = (file.Extension != null);

        // kluge to seperate enums into their own folder
        folderPath = string.Format("{0}/enums/", folderPath);
        if (!Directory.Exists(folderPath)) {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Created directory: {0}", folderPath);
        }

        for (int i = 0; i < file.Groups.Count; i++) {
            GLGroup group = file.Groups[i];
            if (group.Declared || !group.Required || !usedGroups.Contains(group)) {
                continue;
            }
            group.Declared = true;

            string groupFilename = folderPath + string.Format(Resources.EnumFilename, group.Name);
            using (FileStream stream = File.OpenWrite(groupFilename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                if (isExtension) {
                    writer.WriteLine("#if {0}\n", name);
                }

                writer.WriteLine(group.CSDecl);

                if (isExtension) {
                    writer.Write("\n#endif");
                }
            }
            Console.WriteLine("Created file: {0}", groupFilename);
        }
    }

    static void WriteGitignore() {
        using (FileStream stream = File.OpenWrite(Resources.GitignoreFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(Resources.GitignoreCode);
        }
    }

    static void WriteCSProj() {
        using (FileStream stream = File.OpenWrite(Resources.CSProjFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(Resources.CSProjCode);
        }
    }

    static void WriteUsings(List<string> typeList) {
        using (FileStream stream = File.OpenWrite(Resources.IncludeFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            int count = Resources.TypeTable.GetLength(0);
            for (int i = 0; i < count; i++) {
                if (typeList.Contains(Resources.TypeTable[i, 0])) {

                    if (Resources.TypeTable[i, 0] == "GLDEBUGPROC") {
                        writer.Write(Resources.IncludeCode);
                    }
                    writer.WriteLine(Resources.TypeTable[i, 1]);
                }
            }
        }
    }

    static void WriteClasses(List<string> classList) {
        Directory.CreateDirectory(Resources.ObjectFolder);
        for (int i = 0; i < classList.Count; i++) {
            using (FileStream stream = File.OpenWrite(string.Format(Resources.ObjectFilename, classList[i])))
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.Write(Resources.ObjectFormat, classList[i]);
            }
        }
    }
}