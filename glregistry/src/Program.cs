namespace glregistry;

class Program {
    static void Main(string[] args) {
        GLregistry registry;
        using (XmlReader reader = new XmlTextReader(Resources.XmlFilename)) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GLregistry));
            registry = xmlSerializer.Deserialize(reader) as GLregistry;
        }
        registry.Initialize();
        registry.UpdateReferences();

        WriteRegistry(registry);
    }

    static string CreateHeaderGuard(List<string> apis) {
        string hguard = string.Empty;
        int acount = apis.Count;
        for (int i = 0; i < acount; i++) {
            if (i < acount - 1) {
                hguard += string.Format("!{0} && ", apis[i]);
            } else {
                hguard += string.Format("!{0}", apis[i]);
            }
        }
        if (!string.IsNullOrEmpty(hguard)) {
            hguard = string.Format("({0})", hguard);
        }
        return hguard;
    }

    static void WriteRegistry(GLregistry registry) {
        // regenerate the output directory then write all the files based on the above filters
        if (Directory.Exists(Resources.OutputFolder)) {
            Directory.Delete(Resources.OutputFolder, true);
            Console.WriteLine("Old directory found: delete it!");
        }

        Directory.CreateDirectory(Resources.OutputFolder);
        Console.WriteLine("Created directory: {0}", Resources.OutputFolder);

        Directory.CreateDirectory(Resources.OutputEnumFolder);
        Console.WriteLine("Created directory: {0}", Resources.OutputEnumFolder);

        WriteGitignore();
        WriteCSProj();
        WriteUsings(registry);
        WriteClasses(registry);

        SortedDictionary<string, List<GLenumerant>> usedEnumerantsMap = new();
        SortedDictionary<string, List<GLcommand>> usedCommandsMap = new();

        List<GLenumerant> usedFeatureEnumerants = new();
        List<GLcommand> usedFeatureCommands = new();
        foreach (GLfeature feature in registry.Features) {
            if (!usedEnumerantsMap.TryGetValue(feature.Name, out usedFeatureEnumerants)) {
                usedFeatureEnumerants = new();
                usedEnumerantsMap.Add(feature.Name, usedFeatureEnumerants);
            }
            if (!usedCommandsMap.TryGetValue(feature.Name, out usedFeatureCommands)) {
                usedFeatureCommands = new();
                usedCommandsMap.Add(feature.Name, usedFeatureCommands);
            }
        }

        List<GLenumerant> usedExtensionEnumerants = new();
        List<GLcommand> usedExtensionCommands = new();
        foreach (GLextension extension in registry.Extensions) {
            if (!usedEnumerantsMap.TryGetValue(extension.Name, out usedExtensionEnumerants)) {
                usedExtensionEnumerants = new();
                usedEnumerantsMap.Add(extension.Name, usedExtensionEnumerants);
            }
            if (!usedCommandsMap.TryGetValue(extension.Name, out usedExtensionCommands)) {
                usedExtensionCommands = new();
                usedCommandsMap.Add(extension.Name, usedExtensionCommands);
            }
        }

        foreach (GLfeature feature in registry.Features) {
            string headerGuard = string.Format("({0} && {1}_API)", feature.Name, feature.API.ToUpper());
            string featureFolder = string.Format(Resources.OutputFeatureFolder, feature.Name);
            string featureEnumFolder = string.Format(Resources.OutputFeatureEnumFolder, feature.Name);

            if (!Directory.Exists(featureFolder)) {
                Directory.CreateDirectory(featureFolder);
                Console.WriteLine("Created directory: {0}", featureFolder);
            }
            if (!Directory.Exists(featureEnumFolder)) {
                Directory.CreateDirectory(featureEnumFolder);
                Console.WriteLine("Created directory: {0}", featureEnumFolder);
            }

            WriteFeatureConstants(registry, feature, headerGuard, usedFeatureEnumerants, usedEnumerantsMap);
            WriteFeatureCommands(registry, feature, headerGuard, usedFeatureCommands, usedCommandsMap);
        }

        foreach (GLextension extension in registry.Extensions) {
            string headerGuard = "";
            foreach (string api in extension.SupportedAPIs) {
                headerGuard += string.Format("{0}_API || ", api.ToUpper());
            }
            headerGuard = headerGuard.Substring(0, headerGuard.LastIndexOf(" || "));
            if (extension.SupportedAPIs.Count() > 1) {
                headerGuard = string.Format("({0} && ({1}))", extension.Name, headerGuard);
            } else if (extension.SupportedAPIs.Count() == 1) {
                headerGuard = string.Format("({0} && {1})", extension.Name, headerGuard);
            } else {
                headerGuard = extension.Name;
            }

            string extensionFolder = string.Format(Resources.OutputExtensionFolder, extension.Ext + "/" + extension.Name);
            string extensionEnumFolder = string.Format(Resources.OutputExtensionEnumFolder, extension.Ext);
            if (!Directory.Exists(extensionFolder)) {
                Directory.CreateDirectory(extensionFolder);
                Console.WriteLine("Created directory: {0}", extensionFolder);
            }
            if (!Directory.Exists(extensionEnumFolder)) {
                Directory.CreateDirectory(extensionEnumFolder);
                Console.WriteLine("Created directory: {0}", extensionEnumFolder);
            }

            WriteExtensionConstants(registry, extension, headerGuard, usedExtensionEnumerants, usedEnumerantsMap);
            WriteExtensionCommands(registry, extension, headerGuard, usedExtensionCommands, usedCommandsMap);
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

    static void WriteUsings(GLregistry registry) {
        using (FileStream stream = File.OpenWrite(Resources.IncludeFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            int typeCount = Resources.TypeTable.GetLength(0);
            for (int i = 0; i < typeCount; i++) {
                if (registry.Types.Contains(Resources.TypeTable[i, 0])) {
                    if (Resources.TypeTable[i, 0] == "GLDEBUGPROC") {
                        writer.Write(Resources.IncludeCode);
                    }
                    writer.WriteLine(Resources.TypeTable[i, 1]);
                }
            }
        }
    }

    static void WriteClasses(GLregistry registry) {
        Directory.CreateDirectory(Resources.ObjectFolder);
        int count = registry.Classes.Count;
        for (int i = 0; i < count; i++) {
            using (FileStream stream = File.OpenWrite(string.Format(Resources.ObjectFilename, registry.Classes[i])))
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.Write(Resources.ObjectFormat, registry.Classes[i]);
            }
        }
    }

    static void WriteFeatureConstants(GLregistry registry, GLfeature feature, string ohGuard,
        List<GLenumerant> usedEnumerants, SortedDictionary<string, List<GLenumerant>> usedEnumerantsMap) {
        List<GLenumerant> enumerants = new();
        foreach (GLdepends require in feature.Require) {
            foreach (GLreference<GLenumerant> reference in require.Enumerants) {
                GLenumerant enumerant = reference.Reference;
                if (!usedEnumerants.Contains(enumerant)) {
                    usedEnumerants.Add(enumerant);
                }
                if (!enumerants.Contains(enumerant)) {
                    enumerants.Add(enumerant);
                }
            }
        }
        enumerants.Sort((x, y) => {
            ulong xval = Convert.ToUInt64(x.Value, 16);
            ulong yval = Convert.ToUInt64(y.Value, 16);
            int xycomp = xval.CompareTo(yval);
            if (xycomp == 0) {
                // when values are equal, compare on name
                return x.Name.CompareTo(y.Name);
            }
            return xycomp;
        });

        // write constants for each of the enerantlues required by the feature
        string constFilename = string.Format(Resources.ConstantsFilename, feature.Name);
        using (FileStream stream = File.OpenWrite(constFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(Resources.ConstantsHeader, ohGuard, feature.API);
            foreach (GLenumerant value in enumerants) {
                List<string> apis = new();
                foreach (string key in usedEnumerantsMap.Keys) {
                    if (key == feature.Name) {
                        continue;
                    }
                    if (usedEnumerantsMap[key].Contains(value)) {
                        apis.Add(key);
                    }
                }
                string ihGuard = CreateHeaderGuard(apis);
                bool writeGuard = !string.IsNullOrEmpty(ihGuard);

                string type = "GLenum";
                if (value.Name.EndsWith("_BIT") || value.Name.EndsWith("_BITS")) {
                    type = "GLbitfield";
                } else if (value.Name == "GL_TIMEOUT_IGNORED") {
                    type = "GLuint64";
                }

                if (writeGuard) {
                    writer.WriteLine("\n#if {0}", ihGuard);
                    writer.Write(Resources.ConstantsDefinition, value.Name, value.Value, type);
                    writer.WriteLine("\n#endif");
                } else {
                    writer.Write(Resources.ConstantsDefinition, value.Name, value.Value, type);
                }
            }
            writer.Write(Resources.ConstantsFooter);
        }
        Console.WriteLine("File written: {0}", constFilename);
    }

    static void WriteFeatureCommands(GLregistry registry, GLfeature feature, string ohGuard,
        List<GLcommand> usedCommands, SortedDictionary<string, List<GLcommand>> usedCommandsMap) {
        List<GLcommand> commands = new();
        foreach (GLdepends dependency in feature.Require) {
            foreach (GLreference<GLcommand> reference in dependency.Commands) {
                GLcommand command = reference.Reference;
                if (!usedCommands.Contains(command)) {
                    usedCommands.Add(command);
                }
                if (!commands.Contains(command)) {
                    commands.Add(command);
                }
            }
        }
        commands.Sort((x, y) => x.Name.CompareTo(y.Name));

        // write functions for each of the commands required by the feature
        string functionsFilename = string.Format(Resources.FunctionsFilename, feature.Name);
        using (FileStream stream = File.OpenWrite(functionsFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            // write the file text heading which contains the class definition
            writer.Write(Resources.FeatureHeader, ohGuard, feature.API);
            foreach (GLcommand command in commands) {
                List<string> listedInFeatures = new();
                foreach (string key in usedCommandsMap.Keys) {
                    if (key == feature.Name) {
                        continue;
                    }
                    if (usedCommandsMap[key].Exists((command.Equals))) {
                        listedInFeatures.Add(key);
                    }
                }
                string hguard = CreateHeaderGuard(listedInFeatures);

                if (!string.IsNullOrEmpty(hguard)) {
                    writer.Write("\n#if {0}", hguard);
                    writer.Write(Resources.FeatureFunction, command.CDecl, command.CSDecl);
                    writer.WriteLine("#endif");
                } else {
                    writer.Write(Resources.FeatureFunction, command.CDecl, command.CSDecl);
                }

            }
            writer.Write(Resources.FeatureFooter);
        }
        Console.WriteLine("File written: {0}", functionsFilename);
    }

    static void WriteExtensionConstants(GLregistry registry, GLextension extension, string ohGuard,
        List<GLenumerant> usedEnumerants, SortedDictionary<string, List<GLenumerant>> usedEnumerantsMap) {
        List<GLenumerant> enumerants = new();
        foreach (GLdepends require in extension.Require) {
            foreach (GLreference<GLenumerant> reference in require.Enumerants) {
                GLenumerant enumerant = reference.Reference;
                if (!usedEnumerants.Contains(enumerant)) {
                    usedEnumerants.Add(enumerant);
                }
                if (!enumerants.Contains(enumerant)) {
                    enumerants.Add(enumerant);
                }
            }
        }

        if (enumerants.Count < 1) {
            return;
        }

        enumerants.Sort((x, y) => {
            long xval = 0;
            if (x.Value.Contains('-')) {
                xval = Convert.ToInt64(x.Value);
            } else {
                xval = Convert.ToInt64(x.Value, 16);
            }

            long yval = 0;
            if (y.Value.Contains('-')) {
                yval = Convert.ToInt64(y.Value);
            } else {
                yval = Convert.ToInt64(y.Value, 16);
            }

            int xycomp = xval.CompareTo(yval);
            if (xycomp == 0) {
                // when values are equal, compare on name
                return x.Name.CompareTo(y.Name);
            }

            return xycomp;
        });

        // write constants for each of the enerantlues required by the feature
        string constFilename = string.Format(Resources.ExtConstantsFilename, extension.Ext + "/" + extension.Name);
        using (FileStream stream = File.OpenWrite(constFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(Resources.ConstantsHeader, ohGuard, extension.Ext.ToLower());
            foreach (GLenumerant value in enumerants) {
                List<string> apis = new();
                foreach (string key in usedEnumerantsMap.Keys) {
                    if (key == extension.Name) {
                        continue;
                    }
                    if (usedEnumerantsMap[key].Contains(value)) {
                        apis.Add(key);
                    }
                }
                string ihGuard = CreateHeaderGuard(apis);
                bool writeGuard = !string.IsNullOrEmpty(ihGuard);

                string type = "GLenum";
                if (value.Name.EndsWith("_BIT") || value.Name.EndsWith("_BITS")) {
                    type = "GLbitfield";
                } else if (value.Name == "GL_TIMEOUT_IGNORED") {
                    type = "GLuint64";
                }

                if (writeGuard) {
                    writer.WriteLine("\n#if {0}", ihGuard);
                    writer.Write(Resources.ConstantsDefinition, value.Name, value.Value, type);
                    writer.WriteLine("\n#endif");
                } else {
                    writer.Write(Resources.ConstantsDefinition, value.Name, value.Value, type);
                }
            }
            writer.Write(Resources.ConstantsFooter);
        }
        Console.WriteLine("File written: {0}", constFilename);
    }

    static void WriteExtensionCommands(GLregistry registry, GLextension extension, string ohGuard,
        List<GLcommand> usedCommands, SortedDictionary<string, List<GLcommand>> usedCommandsMap) {
        List<GLcommand> commands = new();
        foreach (GLdepends dependency in extension.Require) {
            foreach (GLreference<GLcommand> reference in dependency.Commands) {
                GLcommand command = reference.Reference;
                if (!usedCommands.Contains(command)) {
                    usedCommands.Add(command);
                }
                if (!commands.Contains(command)) {
                    commands.Add(command);
                }
            }
        }

        if (commands.Count < 1) {
            return;
        }

        commands.Sort((x, y) => x.Name.CompareTo(y.Name));

        // write functions for each of the commands required by the feature
        string functionsFilename = string.Format(Resources.ExtFunctionsFilename, extension.Ext + "/" + extension.Name);
        using (FileStream stream = File.OpenWrite(functionsFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            // write the file text heading which contains the class definition
            writer.Write(Resources.FeatureHeader, ohGuard, extension.SupportedAPIs[0]);
            foreach (GLcommand command in commands) {
                List<string> listedInFeatures = new();
                foreach (string key in usedCommandsMap.Keys) {
                    if (key == extension.Name) {
                        continue;
                    }
                    if (usedCommandsMap[key].Exists((command.Equals))) {
                        listedInFeatures.Add(key);
                    }
                }
                string hguard = CreateHeaderGuard(listedInFeatures);

                if (!string.IsNullOrEmpty(hguard)) {
                    writer.Write("\n#if {0}", hguard);
                    writer.Write(Resources.FeatureFunction, command.CDecl, command.CSDecl);
                    writer.WriteLine("#endif");
                } else {
                    writer.Write(Resources.FeatureFunction, command.CDecl, command.CSDecl);
                }

            }
            writer.Write(Resources.FeatureFooter);
        }
        Console.WriteLine("File written: {0}", functionsFilename);
    }
}