static partial class Program {
    static GLRegistry MasterRegistry;

    static void Main(string[] args) {
        MasterRegistry = GLRegistry.ParseRegistry(References.XmlFilename);
        MasterRegistry.Update();

        WriteMaster();
    }

    static void WriteMaster() {
        // regenerate the output directory then write all the files based on the above filters
        if (Directory.Exists(References.OutputFolder)) {
            Directory.Delete(References.OutputFolder, true);
        }
        Directory.CreateDirectory(References.OutputFolder);
        Directory.CreateDirectory(References.OutputEnumFolder);
        WriteGitignore();
        WriteCSProj();
        WriteUsings(MasterRegistry);
        WriteClasses(MasterRegistry);

        SortedDictionary<string, List<GLREnumValue>> usedEnumValuesMap = new();
        SortedDictionary<string, List<GLRCommand>> usedCommandsMap = new();

        List<GLREnumValue> allUsedValues = new();
        List<GLRCommand> allUsedCommands = new();

        foreach (GLRFeature feature in MasterRegistry.Features) {
            List<GLREnumValue> usedEnumValues;
            if (!usedEnumValuesMap.TryGetValue(feature.Name, out usedEnumValues)) {
                usedEnumValues = new();
                usedEnumValuesMap.Add(feature.Name, usedEnumValues);
            }

            List<GLRCommand> usedCommands;
            if (!usedCommandsMap.TryGetValue(feature.Name, out usedCommands)) {
                usedCommands = new();
                usedCommandsMap.Add(feature.Name, usedCommands);
            }

            string ifdef = string.Format("({0} && {1}_API)", feature.Name, feature.API.ToUpper());
            Directory.CreateDirectory(string.Format(References.OutputFeatureFolder, feature.Name));
            Directory.CreateDirectory(String.Format(References.OutputFeatureEnumFolder, feature.Name));

            #region Write - Feature - Constants

            // write constants for each of the enum values required by the feature
            string constFilename = string.Format(References.ConstantsFilename, feature.Name);
            using (FileStream stream = File.OpenWrite(constFilename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.Write(References.ConstantsHeader, ifdef, feature.API);
                foreach (GLREnumValue value in feature.Enums) {
                    if (usedEnumValues.Exists(value.Equals)) {
                        continue;
                    }
                    usedEnumValues.Add(value);

                    if (!allUsedValues.Exists(value.Equals)) {
                        allUsedValues.Add(value);
                    }

                    List<string> apis = new();
                    foreach (string key in usedEnumValuesMap.Keys) {
                        if (key == feature.Name) {
                            continue;
                        }
                        if (usedEnumValuesMap[key].Exists((value.Equals))) {
                            apis.Add(key);
                        }
                    }

                    string hguard = "";
                    foreach (string api in apis) {
                        hguard += string.Format("!{0} && ", api);
                    }
                    if (!string.IsNullOrEmpty(hguard)) {
                        hguard = hguard.Substring(0, hguard.LastIndexOf(" && "));
                        if (apis.Count > 1) {
                            hguard = "(" + hguard + ")";
                        }
                    }

                    string type = "GLenum";
                    if (value.Name.EndsWith("_BIT") || value.Name.EndsWith("_BITS")) {
                        type = "GLbitfield";
                    } else if (value.Name == "GL_TIMEOUT_IGNORED") {
                        type = "GLuint64";
                    }

                    if (!string.IsNullOrEmpty(hguard)) {
                        writer.WriteLine("\n#if {0}", hguard);
                    }

                    writer.Write(References.ConstantsDefinition, value.Name, value.Value, type);

                    if (!string.IsNullOrEmpty(hguard)) {
                        writer.WriteLine("\n#endif");
                    }
                }
                writer.Write(References.ConstantsFooter);
            }

            #endregion

            #region Write - Feature - Functions

            // write functions for each of the commands required by the feature
            string functionsFilename = string.Format(References.FunctionsFilename, feature.Name);
            using (FileStream stream = File.OpenWrite(functionsFilename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                // write the file text heading which contains the class definition
                writer.Write(References.FeatureHeader, ifdef, feature.API);
                foreach (GLRCommand command in feature.Commands) {
                    if (usedCommands.Exists(command.Equals)) {
                        continue;
                    }
                    usedCommands.Add(command);

                    if (!allUsedCommands.Exists(command.Equals)) {
                        allUsedCommands.Add(command);
                    }

                    List<string> listedInFeatures = new();
                    foreach (string key in usedCommandsMap.Keys) {
                        if (key == feature.Name) {
                            continue;
                        }
                        if (usedCommandsMap[key].Exists((command.Equals))) {
                            listedInFeatures.Add(key);
                        }
                    }

                    string hguard = "";
                    foreach (string api in listedInFeatures) {
                        hguard += string.Format("!{0} && ", api);
                    }
                    if (!string.IsNullOrEmpty(hguard)) {
                        hguard = hguard.Substring(0, hguard.LastIndexOf(" && "));
                        if (listedInFeatures.Count > 1) {
                            hguard = "(" + hguard + ")";
                        }
                    }

                    string returnType = ConvertType(command.Prototype.Replace(command.Name, null));
                    string args = "";
                    string argsRaw = "";
                    foreach (GLRCommandParam param in command.Params) {
                        int index = param.Prototype.LastIndexOf(param.Name);
                        string argType = (index > 0) ? param.Prototype.Remove(index) : param.Prototype;
                        string argTypeRaw = argType.Replace(" *", "*");

                        if (!string.IsNullOrEmpty(param.Class)) {
                            // found an object name, a few have spaces so trim those out
                            string objName = string.Format(References.ObjectName, param.Class.Replace(" ", null));
                            argType = argType.Replace(param.Type, objName);
                        } else if (!string.IsNullOrEmpty(param.Group)) {
                            // attempt to find the enum group the value belongs to
                            GLREnumGroup srcGroup = MasterRegistry.MasterGroups.Find((x) => x.Name == param.Group);
                            if (srcGroup != null) {
                                // TODO : preserve pointer count
                                int pIndex = argType.IndexOf('*');
                                string group = param.Group;
                                argType = (pIndex > -1) ? group + "*" : group;
                            }
                        }

                        // in the xml it's defined as an enum, in c it's defined as an aliased 8-bit value
                        argType = argType.Replace("Boolean", "GLboolean");

                        args += ConvertType(argType) + ", ";
                        argsRaw += argTypeRaw + " " + param.Name + ", ";
                    }
                    if (!string.IsNullOrEmpty(argsRaw)) {
                        argsRaw = argsRaw.Substring(0, argsRaw.LastIndexOf(','));
                    }

                    if (!string.IsNullOrEmpty(hguard)) {
                        writer.WriteLine("\n#if {0}", hguard);
                    }

                    writer.Write(References.FeatureFunction, returnType, command.Name, argsRaw, args);

                    if (!string.IsNullOrEmpty(hguard)) {
                        writer.WriteLine("\n#endif");
                    }
                }
                writer.Write(References.FeatureFooter);
            }

            #endregion
        }

        foreach (GLRExtension extension in MasterRegistry.Extensions) {
            string extAbbr = extension.Ext;

            List<GLREnumValue> usedEnumValues;
            if (!usedEnumValuesMap.TryGetValue(extension.Name, out usedEnumValues)) {
                usedEnumValues = new();
                usedEnumValuesMap.Add(extension.Name, usedEnumValues);
            }

            List<GLRCommand> usedCommands;
            if (!usedCommandsMap.TryGetValue(extension.Name, out usedCommands)) {
                usedCommands = new();
                usedCommandsMap.Add(extension.Name, usedCommands);
            }

            string ifdef = "";
            foreach (string api in extension.SupportedAPIs) {
                ifdef += string.Format("{0}_API || ", api.ToUpper());
            }
            ifdef = ifdef.Substring(0, ifdef.LastIndexOf(" || "));
            if (extension.SupportedAPIs.Count > 1) {
                ifdef = string.Format("({0} && ({1}))", extension.Name, ifdef);
            } else if (extension.SupportedAPIs.Count == 1) {
                ifdef = string.Format("({0} && {1})", extension.Name, ifdef);
            } else {
                ifdef = extension.Name;
            }
            Directory.CreateDirectory(string.Format(References.OutputExtensionFolder, extAbbr + "/" + extension.Name));
            Directory.CreateDirectory(string.Format(References.OutputExtensionEnumFolder, extAbbr));

            #region Write - Extension - Constants

            // write constants for each of the enum values required by the extension
            string constFilename = string.Format(References.ExtConstantsFilename, extAbbr + "/" + extension.Name);
            using (FileStream stream = File.OpenWrite(constFilename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.Write(References.ExtConstantsHeader, ifdef, "glext_" + extAbbr.ToLower());//extension.SupportedAPIs[0]);
                foreach (GLREnumValue value in extension.Enums) {
                    if (usedEnumValues.Exists(value.Equals)) {
                        continue;
                    }
                    usedEnumValues.Add(value);

                    if (!allUsedValues.Exists(value.Equals)) {
                        allUsedValues.Add(value);
                    }

                    string type = "GLenum";
                    if (value.Name.EndsWith("_BIT") || value.Name.EndsWith("_BITS")) {
                        type = "GLbitfield";
                    } else if (value.Name == "GL_TIMEOUT_IGNORED") {
                        type = "GLuint64";
                    }

                    writer.Write(References.ExtConstantsDefinition, value.Name, value.Value, type);
                }
                writer.Write(References.ExtConstantsFooter);
            }

            #endregion

            #region Write - Extension - Functions

            // write functions for each of the commands required by the extension
            string functionsFilename = string.Format(References.ExtFunctionsFilename, extAbbr + "/" + extension.Name);
            using (FileStream stream = File.OpenWrite(functionsFilename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                // write the file text heading which contains the class definition
                writer.Write(References.ExtFeatureHeader, ifdef, extension.SupportedAPIs[0]);
                foreach (GLRCommand command in extension.Commands) {
                    if (usedCommands.Exists(command.Equals)) {
                        continue;
                    }
                    usedCommands.Add(command);

                    if (!allUsedCommands.Exists(command.Equals)) {
                        allUsedCommands.Add(command);
                    }

                    string returnType = ConvertType(command.Prototype.Replace(command.Name, null));
                    string args = "";
                    string argsRaw = "";
                    foreach (GLRCommandParam param in command.Params) {
                        int index = param.Prototype.LastIndexOf(param.Name);
                        string argType = (index > 0) ? param.Prototype.Remove(index) : param.Prototype;
                        string argTypeRaw = argType.Replace(" *", "*");

                        if (!string.IsNullOrEmpty(param.Class)) {
                            // found an object name, a few have spaces so trim those out
                            string objName = string.Format(References.ObjectName, param.Class.Replace(" ", null));
                            argType = argType.Replace(param.Type, objName);
                        } else if (!string.IsNullOrEmpty(param.Group)) {
                            // attempt to find the enum group the value belongs to
                            GLREnumGroup srcGroup = MasterRegistry.MasterGroups.Find((x) => x.Name == param.Group);
                            if (srcGroup != null) {
                                // TODO : preserve pointer count
                                int pIndex = argType.IndexOf('*');
                                string group = param.Group;
                                argType = (pIndex > -1) ? group + "*" : group;

                                // if (!usedGroups.Exists(srcGroup.Equals)) {
                                //     usedGroups.Add(srcGroup);
                                // }
                            }
                        }

                        // in the xml it's defined as an enum, in c it's defined as an aliased 8-bit value
                        argType = argType.Replace("Boolean", "GLboolean");

                        args += ConvertType(argType) + ", ";
                        argsRaw += argTypeRaw + " " + param.Name + ", ";
                    }
                    if (!string.IsNullOrEmpty(argsRaw)) {
                        argsRaw = argsRaw.Substring(0, argsRaw.LastIndexOf(','));
                    }
                    writer.Write(References.ExtFeatureFunction, returnType, command.Name, argsRaw, args);
                }
                writer.Write(References.ExtFeatureFooter);
            }

            #endregion
        }

        // construct all possible enum groups from the all enum values list
        List<GLREnumGroup> allUsedGroups = new();
        foreach (GLREnumValue value in allUsedValues) {
            foreach (string groupName in value.Groups) {
                GLREnumGroup outGroup = allUsedGroups.Find((x) => x.Name == groupName);
                if (outGroup == null) {
                    outGroup = new GLREnumGroup() {
                        Name = groupName,
                        Type = !string.IsNullOrEmpty(groupName) && groupName.EndsWith("Mask") ? "GLbitfield" : "GLenum"
                    };
                    allUsedGroups.Add(outGroup);
                }
                if (!outGroup.Values.Exists(value.Equals)) {
                    outGroup.Values.Add(value);
                }
            }
        }

        // write enums for each of the enum groups required by the feature
        foreach (GLREnumGroup group in allUsedGroups) {
            List<string> allAPIs = new();
            foreach (GLREnumValue value in group.Values) {
                foreach (string key in usedEnumValuesMap.Keys) {
                    List<GLREnumValue> enumValues = usedEnumValuesMap[key];
                    if (enumValues.Exists((x) => x.Name == value.Name) && !allAPIs.Exists(key.Equals)) {
                        allAPIs.Add(key);
                    }
                }
            }

            string hguard = "";
            foreach (string api in allAPIs) {
                hguard += string.Format("{0} || ", api.ToUpper());
            }
            if (!string.IsNullOrEmpty(hguard)) {
                hguard = hguard.Substring(0, hguard.LastIndexOf(" || "));
                if (allAPIs.Count > 1) {
                    hguard = "(" + hguard + ")";
                }
            }

            string outGroupName = group.Name;
            string enumFilename = string.Format(References.EnumFilename, outGroupName);

            string outExt = Regex.Match(outGroupName, "[A-Z][A-Z]+").Value;
            if (outExt == "PN") {
                outExt = Regex.Match(outGroupName, "[A-Z][A-Z][A-Z]+").Value;
            }

            if (MasterRegistry.Extensions.Exists((x) => x.Ext == outExt)) {
                enumFilename = string.Format(References.ExtensionEnumFilename, outExt, outGroupName);
            } else if (allAPIs.Count == 1) {
                GLRExtension ext = MasterRegistry.Extensions.Find((x) => x.Name == allAPIs[0]);
                if (ext != null) {
                    enumFilename = string.Format(References.ExtensionEnumFilename, ext.Ext, outGroupName);
                } else {
                    enumFilename = string.Format(References.FeatureEnumFilename, allAPIs[0], outGroupName);
                }
            }


            using (FileStream stream = File.Open(enumFilename, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream)) {
                if (!string.IsNullOrEmpty(hguard)) {
                    writer.WriteLine("#if {0}", hguard);
                }
                string type = group.Name.EndsWith("Mask") ? "GLbitfield" : "GLenum";
                if (type.Equals("GLbitfield")) {
                    writer.Write("[Flags]");
                }

                writer.Write(References.EnumHeader, outGroupName, type);
                if (type.Equals("GLbitfield")) {
                    // need a none value for flags enum usability
                    writer.Write("\n    None = 0,");
                }

                foreach (GLREnumValue value in group.Values) {
                    string[] nameWords = value.Name.Split('_');
                    string name = string.Empty;

                    // process the spec's naming to produce a reasonable C# equivalent
                    for (int i = 1; i < nameWords.Length; i++) {
                        if (i == nameWords.Length - 1 && (nameWords[i] == "BIT" || nameWords[i] == "BITS")) {
                            continue;
                        }
                        if (nameWords[i] == "1D" || nameWords[i] == "2D" || nameWords[i] == "3D") {
                            // don't adjust dimension spec, just reads badly
                            name += nameWords[i];
                        } else {
                            // caps to camel hump conversion
                            name += nameWords[i][0];
                            name += nameWords[i].Substring(1).ToLower();
                        }
                    }

                    // the value name starts with a number, just prefix it with an underscore
                    if (name[0] == '0' || name[0] == '1' || name[0] == '2' || name[0] == '3' || name[0] == '4' ||
                        name[0] == '5' || name[0] == '6' || name[0] == '7' || name[0] == '8' || name[0] == '9') {
                        name = "_" + name;
                    }

                    // try to further clean up the name based on it's container name
                    string outNameFilter = "";
                    string[] nameParts = Regex.Split(name, "([a-z])(?=[A-Z])");
                    string[] valueParts = Regex.Split(group.Name, "([a-z])(?=[A-Z])");
                    int minLength = Math.Min(nameParts.Length, valueParts.Length);
                    for (int i = 0; i < minLength - 1; i += 2) {
                        string tname = nameParts[i] + nameParts[i + 1];
                        string tvalue = valueParts[i] + valueParts[i + 1];
                        if (tname == tvalue) {
                            outNameFilter += tname;
                        }
                    }
                    if (outNameFilter.Length > 0) {
                        name = name.Replace(outNameFilter, null);
                    }

                    List<string> apis = new();
                    foreach (string key in usedEnumValuesMap.Keys) {
                        List<GLREnumValue> enumValues = usedEnumValuesMap[key];
                        if (enumValues.Exists((x) => x.Name == value.Name) && !apis.Exists(key.Equals)) {
                            apis.Add(key);
                        }
                    }

                    string ifdef = "";
                    foreach (string api in apis) {
                        ifdef += string.Format("{0} || ", api.ToUpper());
                    }
                    if (!string.IsNullOrEmpty(ifdef)) {
                        ifdef = ifdef.Substring(0, ifdef.LastIndexOf(" || "));
                        if (apis.Count > 1) {
                            ifdef = "(" + ifdef + ")";
                        }
                    }

                    writer.Write(References.EnumCode, name, value.Name, ifdef);
                }
                writer.Write(References.EnumFooter);
                if (!string.IsNullOrEmpty(hguard)) {
                    writer.WriteLine("\n#endif");
                }
            }
        }
    }

    // filters out const pointer types, no applicable 'unmanaged' C# equivalent
    static string ConvertType(string type) => type.Replace("const", null).Replace(" ", null);

    public static readonly string[,] EnumNameSubs = new string[,] {
        { "VertexAttribPointerType", "VertexAttribType" },
        { "VertexAttribIType", "VertexAttribType" },
        { "VertexAttribLType", "VertexAttribType" },

        { "BufferUsageARB", "BufferUsage" },
        { "VertexBufferObjectUsage" , "BufferUsage" }
    };

    static void WriteRegistry(GLRegistry registry) {
        // regenerate the output directory then write all the files based on the above filters
        if (Directory.Exists(References.OutputFolder)) {
            Directory.Delete(References.OutputFolder, true);
        }
        Directory.CreateDirectory(References.OutputFolder);
        Directory.CreateDirectory(References.OutputEnumFolder);
        WriteCSProj();
        WriteUsings(registry);
        WriteClasses(registry);
        WriteConstants(registry);
        List<string> usedGroups = WriteFunctions(registry);
        WriteEnumGroups(registry);

        return;

        // foreach (string groupName in usedGroups) {
        //     WriteEnum(groupName, removeEnums, usedConsts);
        // }
    }

    static void WriteGitignore() {
        using (FileStream stream = File.OpenWrite(References.GitignoreFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(References.GitignoreCode);
        }
    }

    static void WriteCSProj() {
        using (FileStream stream = File.OpenWrite(References.CSProjFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(References.CSProjCode);
        }
    }

    static void WriteUsings(GLRegistry registry) {
        using (FileStream stream = File.OpenWrite(References.IncludeFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            int typeCount = References.TypeTable.GetLength(0);
            for (int i = 0; i < typeCount; i++) {
                if (registry.Types.Exists(References.TypeTable[i, 0].Equals)) {
                    if (References.TypeTable[i, 0] == "GLDEBUGPROC") {
                        writer.Write(References.IncludeCode);
                    }
                    writer.WriteLine(References.TypeTable[i, 1]);
                }
            }
        }
    }

    static void WriteClasses(GLRegistry registry) {
        Directory.CreateDirectory(References.ObjectFolder);
        registry.Classes.ForEach((cls) => {
            using (FileStream stream = File.OpenWrite(string.Format(References.ObjectFilename, cls.Replace(" ", null))))
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.Write(References.ObjectFormat, cls.Replace(" ", null));
            }
        });
    }

    static void WriteConstants(GLRegistry registry) {
        GLREnumGroup constants = registry.EnumGroups.Find((x) => x.Name.Equals("Constants"));
        List<GLREnumValue> usedValues = new();
        foreach (GLRFeature feature in registry.Features) {
            // constants that are required by the current feature 
            List<GLREnumValue> featureConsts = constants.Values.FindAll((x) =>
                feature.RequireEnums.Exists(x.Name.Equals) &&
                !usedValues.Exists(x.Equals)
            );
            usedValues.AddRange(featureConsts.FindAll((x) => !usedValues.Exists(x.Equals)));
            featureConsts.Sort((x, y) => Convert.ToUInt64(x.Value, 16).CompareTo(Convert.ToUInt64(y.Value, 16)));

            string filename = string.Format(References.ConstantsFilename, feature.Name);
            if (File.Exists(filename)) {
                File.Delete(filename);
            }
            Directory.CreateDirectory(string.Format(References.OutputFeatureFolder, feature.Name));

            using (FileStream stream = File.OpenWrite(filename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.Write(References.ConstantsHeader, feature.Name, feature.API);
                foreach (GLREnumValue value in featureConsts) {
                    string type = "GLenum";
                    if (value.Name.EndsWith("_BIT") || value.Name.EndsWith("_BITS")) {
                        type = "GLbitfield";
                    } else if (value.Name == "GL_TIMEOUT_IGNORED") {
                        type = "GLuint64";
                    }
                    writer.Write(References.ConstantsDefinition, value.Name, value.Value, type);
                }
                writer.Write(References.ConstantsFooter);
            }
        }
    }

    static List<string> WriteFunctions(GLRegistry registry) {
        List<string> usedGroups = new();
        List<GLRCommand> usedCommands = new();
        foreach (GLRFeature feature in registry.Features) {
            List<GLRCommand> commands = registry.Commands.FindAll((command) =>
                feature.RequireCommands.Exists(command.Name.Equals) &&
                !usedCommands.Exists(command.Equals)
            );
            usedCommands.AddRange(commands.FindAll((command) => !usedCommands.Exists(command.Equals)));

            // clear the existing folder to avoid mixing old and new files
            string filename = string.Format(References.FunctionsFilename, feature.Name);
            if (File.Exists(filename)) {
                File.Delete(filename);
            }
            Directory.CreateDirectory(string.Format(References.OutputFeatureFolder, feature.Name));

            using (FileStream stream = File.OpenWrite(filename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                // write the file text heading which contains the class definition
                writer.Write(References.FeatureHeader, feature.Name, feature.API);
                foreach (GLRCommand command in commands) {
                    string returnType = ConvertType(command.Prototype.Replace(command.Name, null));
                    string args = "";
                    string argsRaw = "";
                    foreach (GLRCommandParam param in command.Params) {
                        int index = param.Prototype.LastIndexOf(param.Name);
                        string argType = (index > 0) ? param.Prototype.Remove(index) : param.Prototype;
                        string argTypeRaw = argType.Replace(" *", "*");

                        if (!string.IsNullOrEmpty(param.Class)) {
                            // found an object name, a few have spaces so trim those out
                            string objName = string.Format(References.ObjectName, param.Class.Replace(" ", null));
                            argType = argType.Replace(param.Type, objName);
                        } else if (!string.IsNullOrEmpty(param.Group)) {
                            // attempt to find the enum group the value belongs to
                            GLREnumGroup srcGroup = registry.MasterGroups.Find((x) => x.Name == param.Group);
                            if (srcGroup != null) {
                                // TODO : preserve pointer count
                                int pIndex = argType.IndexOf('*');
                                string group = param.Group;
                                argType = (pIndex > -1) ? group + "*" : group;

                                if (!usedGroups.Exists(param.Group.Equals)) {
                                    usedGroups.Add(param.Group);
                                }
                            }
                        }

                        // in the xml it's defined as an enum, in c it's defined as an aliased 8-bit value
                        argType = argType.Replace("Boolean", "GLboolean");

                        args += ConvertType(argType) + ", ";
                        argsRaw += argTypeRaw + " " + param.Name + ", ";
                    }
                    if (!string.IsNullOrEmpty(argsRaw)) {
                        argsRaw = argsRaw.Substring(0, argsRaw.LastIndexOf(','));
                    }
                    writer.Write(References.FeatureFunction, returnType, command.Name, argsRaw, args);
                }
                writer.Write(References.FeatureFooter);
            }
        }
        usedGroups.Sort((x, y) => x.CompareTo(y));
        return usedGroups;
    }

    static void WriteEnumGroups(GLRegistry registry) {
        List<GLREnumGroup> masterGroups = registry.EnumGroups.FindAll((group) =>
            group.Name != "Constants" &&
            group.Name != "Boolean"
        );
        foreach (GLREnumGroup masterGroup in masterGroups) {
            string outGroupName = masterGroup.Name;
            string filename = string.Format(References.EnumFilename, outGroupName);

            using (FileStream stream = File.Open(filename, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream)) {
                string type = masterGroup.Name.EndsWith("Mask") ? "GLbitfield" : "GLenum";
                if (type.Equals("GLbitfield")) {
                    writer.Write("[Flags]");
                }

                writer.Write(References.EnumHeader, outGroupName, type);
                if (type.Equals("GLbitfield")) {
                    // need a none value for flags enum usability
                    writer.Write("\n    None = 0,");
                }

                foreach (GLREnumValue value in masterGroup.Values) {
                    string[] nameWords = value.Name.Split('_');
                    string name = string.Empty;

                    // process the spec's naming to produce a reasonable C# equivalent
                    for (int i = 1; i < nameWords.Length; i++) {
                        if (i == nameWords.Length - 1 && (nameWords[i] == "BIT" || nameWords[i] == "BITS")) {
                            continue;
                        }
                        if (nameWords[i] == "1D" || nameWords[i] == "2D" || nameWords[i] == "3D") {
                            // don't adjust dimension spec, just reads badly
                            name += nameWords[i];
                        } else {
                            // caps to camel hump conversion
                            name += nameWords[i][0];
                            name += nameWords[i].Substring(1).ToLower();
                        }
                    }

                    // the value name starts with a number, just prefix it with an underscore
                    if (name[0] == '0' || name[0] == '1' || name[0] == '2' || name[0] == '3' || name[0] == '4' ||
                        name[0] == '5' || name[0] == '6' || name[0] == '7' || name[0] == '8' || name[0] == '9') {
                        name = "_" + name;
                    }

                    // try to further clean up the name based on it's container name
                    string outNameFilter = "";
                    string[] nameParts = Regex.Split(name, "([a-z])(?=[A-Z])");
                    string[] valueParts = Regex.Split(masterGroup.Name, "([a-z])(?=[A-Z])");
                    int minLength = Math.Min(nameParts.Length, valueParts.Length);
                    for (int i = 0; i < minLength - 1; i += 2) {
                        string tname = nameParts[i] + nameParts[i + 1];
                        string tvalue = valueParts[i] + valueParts[i + 1];
                        if (tname == tvalue) {
                            outNameFilter += tname;
                        }
                    }
                    if (outNameFilter.Length > 0) {
                        name = name.Replace(outNameFilter, null);
                    }

                    writer.Write(References.EnumCode, name, value.Name);
                }
                writer.Write(References.EnumFooter);
            }
        }
    }
}