namespace glregistry;

public static class Generator {
    public static void WriteRegistry(GLregistry registry) {
        // regenerate the output directory then write all the files based on the above filters
        if (Directory.Exists(References.OutputFolder)) {
            Directory.Delete(References.OutputFolder, true);
        }
        Directory.CreateDirectory(References.OutputFolder);
        Directory.CreateDirectory(References.OutputEnumFolder);
        WriteGitignore();
        WriteCSProj();
        WriteUsings(registry);
        // WriteClasses(registry);

        SortedDictionary<string, List<GLenumerant>> usedEnumValuesMap = new();
        SortedDictionary<string, List<GLcommand>> usedCommandsMap = new();
        List<GLenumerant> usedFeatureEnumValues = new();
        List<GLenumerant> usedExtensionEnumValues = new();
        List<GLcommand> usedFeatureCommands = new();
        List<GLcommand> usedExtensionCommands = new();
        List<GLenumerant> allUsedValues = new();
        List<GLgroup> allUsedGroups = new();
        List<GLcommand> allUsedCommands = new();

        foreach (GLfeature feature in registry.Features) {
            if (!usedEnumValuesMap.TryGetValue(feature.Name, out usedFeatureEnumValues)) {
                usedFeatureEnumValues = new();
                usedEnumValuesMap.Add(feature.Name, usedFeatureEnumValues);
            }
            if (!usedCommandsMap.TryGetValue(feature.Name, out usedFeatureCommands)) {
                usedFeatureCommands = new();
                usedCommandsMap.Add(feature.Name, usedFeatureCommands);
            }
        }

        foreach (GLextension extension in registry.Extensions) {
            if (!usedEnumValuesMap.TryGetValue(extension.Name, out usedExtensionEnumValues)) {
                usedExtensionEnumValues = new();
                usedEnumValuesMap.Add(extension.Name, usedExtensionEnumValues);
            }
            if (!usedCommandsMap.TryGetValue(extension.Name, out usedExtensionCommands)) {
                usedExtensionCommands = new();
                usedCommandsMap.Add(extension.Name, usedExtensionCommands);
            }
        }

        foreach (GLfeature feature in registry.Features) {
            string headerGuard = string.Format("({0} && {1}_API)", feature.Name, feature.API.ToUpper());
            string featureFolder = string.Format(References.OutputFeatureFolder, feature.Name);
            string featureEnumFolder = string.Format(References.OutputFeatureEnumFolder, feature.Name);

            if (!Directory.Exists(featureFolder)) {
                Directory.CreateDirectory(featureFolder);
            }
            if (!Directory.Exists(featureEnumFolder)) {
                Directory.CreateDirectory(featureEnumFolder);
            }
            WriteFeatureConstants(feature, headerGuard, usedFeatureEnumValues, allUsedValues, usedEnumValuesMap);
            WriteFeatureCommands(registry, feature, headerGuard, usedFeatureCommands, allUsedCommands, usedCommandsMap);
        }

        foreach (GLextension extension in registry.Extensions) {
            string headerGuard = "";
            foreach (string api in extension.SupportedAPIs) {
                headerGuard += string.Format("{0}_API || ", api.ToUpper());
            }
            headerGuard = headerGuard.Substring(0, headerGuard.LastIndexOf(" || "));
            if (extension.SupportedAPIs.Count > 1) {
                headerGuard = string.Format("({0} && ({1}))", extension.Name, headerGuard);
            } else if (extension.SupportedAPIs.Count == 1) {
                headerGuard = string.Format("({0} && {1})", extension.Name, headerGuard);
            } else {
                headerGuard = extension.Name;
            }

            string extAbbr = extension.Ext;
            string extensionFolder = string.Format(References.OutputExtensionFolder, extAbbr + "/" + extension.Name);
            string extensionEnumFolder = string.Format(References.OutputExtensionEnumFolder, extAbbr);
            if (!Directory.Exists(extensionFolder)) {
                Directory.CreateDirectory(extensionFolder);
            }
            if (!Directory.Exists(extensionEnumFolder)) {
                Directory.CreateDirectory(extensionEnumFolder);
            }

            WriteExtensionConstants(extension, headerGuard, extAbbr, usedExtensionEnumValues, allUsedValues, usedEnumValuesMap);
            // WriteExtensionCommands(registry, extension, headerGuard, extAbbr, usedExtensionCommands, allUsedCommands, usedCommandsMap);
        }

        // construct all possible enum groups from the all enum values list
        foreach (GLenumerant value in allUsedValues) {
            foreach (string groupName in value.Groups) {
                GLgroup outGroup = allUsedGroups.Find((x) => x.Name == groupName);
                if (outGroup == null) {
                    outGroup = new GLgroup() {
                        Name = groupName,
                        Type = !string.IsNullOrEmpty(groupName) && groupName.EndsWith("Mask") ? "GLbitfield" : "GLenum"
                    };
                    allUsedGroups.Add(outGroup);
                }
                if (!outGroup.ContainsEnum(value)) {
                    outGroup.AddEnums(value);
                }
            }
        }

        // clean up the used group list
        List<string> usedGroupsToRemove = new();
        allUsedGroups.RemoveAll((x) => Array.Exists(References.RemoveGroups, x.Name.Equals));
        foreach (string groupName in References.MergeGroups.Keys) {
            string newGroupName = References.MergeGroups[groupName];

            // try to fetch an existing group for the merge source
            GLgroup group = allUsedGroups.Find((x) => x.Name == groupName);
            if (group == null) {
                continue;
            }
            if (groupName != newGroupName && !usedGroupsToRemove.Contains(groupName)) {
                usedGroupsToRemove.Add(groupName);
            }

            // try to fetch an existing group for the merge target
            GLgroup newGroup = allUsedGroups.Find((x) => x.Name == newGroupName);
            if (newGroup == null) {
                newGroup = new() {
                    Name = References.MergeGroups[groupName],
                    Type = group.Type
                };
                allUsedGroups.Add(newGroup);
            }

            // merge the values of the source into the target
            foreach (GLenumerant value in group.Enumerants) {
                GLenumerant newValue = (from enumerant in newGroup.Enumerants
                                        where enumerant.Name == value.Name
                                        select enumerant).FirstOrDefault();

                if (newValue == null) {
                    newValue = new() {
                        Name = value.Name,
                        Value = value.Value
                    };
                    newGroup.AddEnums(newValue);
                }
                newValue.AddGroups((from valGroupName in value.Groups
                                    where !newValue.Groups.Contains(valGroupName)
                                    select valGroupName).ToArray());
            }
        }
        allUsedGroups.RemoveAll((x) => usedGroupsToRemove.Contains(x.Name));

        // write enums for each of the enum groups required by the feature
        foreach (GLgroup group in allUsedGroups) {
            List<string> allAPIs = new();
            foreach (GLenumerant value in group.Enumerants) {
                foreach (string key in usedEnumValuesMap.Keys) {
                    List<GLenumerant> enumValues = usedEnumValuesMap[key];
                    if (enumValues.Exists((x) => x.Name == value.Name) && !allAPIs.Exists(key.Equals)) {
                        allAPIs.Add(key);
                    }
                }
            }

            string headerGaurd = "";
            foreach (string api in allAPIs) {
                headerGaurd += string.Format("{0} || ", api.ToUpper());
            }
            if (!string.IsNullOrEmpty(headerGaurd)) {
                headerGaurd = headerGaurd.Substring(0, headerGaurd.LastIndexOf(" || "));
                if (allAPIs.Count > 1) {
                    headerGaurd = "(" + headerGaurd + ")";
                }
            }

            string outGroupName = group.Name;
            string enumFilename = string.Format(References.EnumFilename, outGroupName);

            string outExt = Regex.Match(outGroupName, "[A-Z][A-Z]+").Value;
            if (outExt == "PN") {
                outExt = Regex.Match(outGroupName, "[A-Z][A-Z][A-Z]+").Value;
            }

            if (registry.Extensions.Exists((x) => x.Ext == outExt)) {
                enumFilename = string.Format(References.ExtensionEnumFilename, outExt, outGroupName);
            } else if (allAPIs.Count == 1) {
                GLextension ext = registry.Extensions.Find((x) => x.Name == allAPIs[0]);
                if (ext != null) {
                    enumFilename = string.Format(References.ExtensionEnumFilename, ext.Ext, outGroupName);
                } else {
                    enumFilename = string.Format(References.FeatureEnumFilename, allAPIs[0], outGroupName);
                }
            }


            using (FileStream stream = File.Open(enumFilename, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream)) {
                if (!string.IsNullOrEmpty(headerGaurd)) {
                    writer.WriteLine("#if {0}", headerGaurd);
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

                foreach (GLenumerant value in group.Enumerants) {
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
                        List<GLenumerant> enumValues = usedEnumValuesMap[key];
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
                if (!string.IsNullOrEmpty(headerGaurd)) {
                    writer.WriteLine("\n#endif");
                }
            }
        }
    }

    // filters out const pointer types, no applicable 'unmanaged' C# equivalent
    public static string ConvertType(string type) {
        string result = type.Replace("const", null)
                            .Replace(" ", null)
                            .Replace("Boolean", "GLboolean");

        // preserve the pointer count of pointer parameters
        string pStr = "";
        int pIndex = 0;
        while ((pIndex = type.IndexOf('*', pIndex)) > -1) {
            pStr += "*";
            pIndex = type.IndexOf('*', pIndex);
        }
        return result.Replace("*", null) + pStr;
    }

    static void WriteFeatureConstants(GLfeature feature, string ifdef, List<GLenumerant> usedEnumValues, List<GLenumerant> allUsedValues,
        SortedDictionary<string, List<GLenumerant>> usedEnumValuesMap) {
        List<GLenumerant> enumerants = new();
        foreach (GLdepends dependency in feature.Require) {
            foreach (GLreference<GLenumerant> reference in dependency.Enumerants) {
                GLenumerant enumerant = reference.Reference;
                if (!usedEnumValues.Contains(enumerant) && !enumerants.Contains(enumerant)) {
                    usedEnumValues.Add(enumerant);
                    enumerants.Add(enumerant);
                }
                if (!allUsedValues.Contains(enumerant)) {
                    allUsedValues.Add(enumerant);
                }
            }
        }

        // write constants for each of the enerantlues required by the feature
        string constFilename = string.Format(References.ConstantsFilename, feature.Name);
        using (FileStream stream = File.OpenWrite(constFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(References.ConstantsHeader, ifdef, feature.API);
            foreach (GLenumerant value in enumerants) {
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
    }

    static void WriteFeatureCommands(GLregistry registry, GLfeature feature, string ifdef, List<GLcommand> usedCommands, List<GLcommand> allUsedCommands,
        SortedDictionary<string, List<GLcommand>> usedCommandsMap) {
        List<GLcommand> commands = new();
        foreach (GLdepends dependency in feature.Require) {
            foreach (GLreference<GLcommand> reference in dependency.Commands) {
                GLcommand enumerant = reference.Reference;
                if (!usedCommands.Contains(enumerant) && !commands.Contains(enumerant)) {
                    usedCommands.Add(enumerant);
                    commands.Add(enumerant);
                }
                if (!allUsedCommands.Contains(enumerant)) {
                    allUsedCommands.Add(enumerant);
                }
            }
        }

        // write functions for each of the commands required by the feature
        string functionsFilename = string.Format(References.FunctionsFilename, feature.Name);
        using (FileStream stream = File.OpenWrite(functionsFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            // write the file text heading which contains the class definition
            writer.Write(References.FeatureHeader, ifdef, feature.API);
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

                string returnType = ConvertType(command.Prototype.Type.Replace(command.Name, null));
                string args = "";
                string argsRaw = "";
                foreach (GLprototype param in command.Parameters) {
                    string prototype = string.Join(" ", command.Prototype);
                    int index = prototype.LastIndexOf(param.Name);
                    string argType = (index > 0) ? prototype.Remove(index) : prototype;
                    string argTypeRaw = argType.Replace(" *", "*");

                    if (!string.IsNullOrEmpty(param.Class)) {
                        // found an object name, a few have spaces so trim those out
                        string objName = string.Format(References.ObjectName, param.Class.Replace(" ", null));
                        argType = argType.Replace(param.TypeRef.ToString(), objName);
                    } else if (!string.IsNullOrEmpty(param.Group)) {
                        // attempt to find the enum group the value belongs to
                        GLgroup srcGroup = registry.Groups.Find((x) => x.Name == param.Group);
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
    }

    static void WriteExtensionConstants(GLextension extension, string ifdef, string extAbbr, List<GLenumerant> usedEnumValues, List<GLenumerant> allUsedValues,
        SortedDictionary<string, List<GLenumerant>> usedEnumValuesMap) {
        List<GLenumerant> enumerants = new();
        foreach (GLdepends dependency in extension.Require) {
            foreach (GLreference<GLenumerant> reference in dependency.Enumerants) {
                GLenumerant enumerant = reference.Reference;
                if (!usedEnumValues.Contains(enumerant) && !enumerants.Contains(enumerant)) {
                    usedEnumValues.Add(enumerant);
                    enumerants.Add(enumerant);
                }
                if (!allUsedValues.Contains(enumerant)) {
                    allUsedValues.Add(enumerant);
                }
            }
        }

        // write constants for each of the enerantlues required by the extension
        string constFilename = string.Format(References.ExtConstantsFilename, extAbbr + "/" + extension.Name);
        using (FileStream stream = File.OpenWrite(constFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(References.ExtConstantsHeader, ifdef, "glext_" + extAbbr.ToLower());//extension.SupportedAPIs[0]);
            foreach (GLenumerant value in enumerants) {
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
    }

    // static void WriteExtensionCommands(GLregistry registry, GLextension extension, string ifdef, string extAbbr, List<GLcommand> usedCommands, List<GLcommand> allUsedCommands,
    //     SortedDictionary<string, List<GLcommand>> usedCommandsMap) {
    //     // write functions for each of the commands required by the extension
    //     string functionsFilename = string.Format(References.ExtFunctionsFilename, extAbbr + "/" + extension.Name);
    //     using (FileStream stream = File.OpenWrite(functionsFilename))
    //     using (StreamWriter writer = new StreamWriter(stream)) {
    //         // write the file text heading which contains the class definition
    //         writer.Write(References.ExtFeatureHeader, ifdef, extension.SupportedAPIs[0]);
    //         foreach (GLcommand command in extension.Commands) {
    //             if (usedCommands.Exists(command.Equals)) {
    //                 continue;
    //             }
    //             usedCommands.Add(command);

    //             if (!allUsedCommands.Exists(command.Equals)) {
    //                 allUsedCommands.Add(command);
    //             }

    //             string returnType = ConvertType(command.Prototype.Replace(command.Name, null));
    //             string args = "";
    //             string argsRaw = "";
    //             foreach (GLcommandParam param in command.Params) {
    //                 int index = param.Prototype.LastIndexOf(param.Name);
    //                 string argType = (index > 0) ? param.Prototype.Remove(index) : param.Prototype;
    //                 string argTypeRaw = argType.Replace(" *", "*");

    //                 if (!string.IsNullOrEmpty(param.Class)) {
    //                     // found an object name, a few have spaces so trim those out
    //                     string objName = string.Format(References.ObjectName, param.Class.Replace(" ", null));
    //                     argType = argType.Replace(param.Type, objName);
    //                 } else if (!string.IsNullOrEmpty(param.Group)) {
    //                     // attempt to find the enum group the value belongs to
    //                     GLRGroup srcGroup = registry.Groups.Find((x) => x.Name == param.Group);
    //                     if (srcGroup != null) {
    //                         // TODO : preserve pointer count
    //                         int pIndex = argType.IndexOf('*');
    //                         string group = param.Group;
    //                         argType = (pIndex > -1) ? group + "*" : group;

    //                         // if (!usedGroups.Exists(srcGroup.Equals)) {
    //                         //     usedGroups.Add(srcGroup);
    //                         // }
    //                     }
    //                 }

    //                 // in the xml it's defined as an enum, in c it's defined as an aliased 8-bit value
    //                 argType = argType.Replace("Boolean", "GLboolean");

    //                 args += ConvertType(argType) + ", ";
    //                 argsRaw += argTypeRaw + " " + param.Name + ", ";
    //             }
    //             if (!string.IsNullOrEmpty(argsRaw)) {
    //                 argsRaw = argsRaw.Substring(0, argsRaw.LastIndexOf(','));
    //             }
    //             writer.Write(References.ExtFeatureFunction, returnType, command.Name, argsRaw, args);
    //         }
    //         writer.Write(References.ExtFeatureFooter);
    //     }
    // }

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

    static void WriteUsings(GLregistry registry) {
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

    // static void WriteClasses(GLregistry registry) {
    //     Directory.CreateDirectory(References.ObjectFolder);
    //     registry.Classes.ForEach((cls) => {
    //         using (FileStream stream = File.OpenWrite(string.Format(References.ObjectFilename, cls.Replace(" ", null))))
    //         using (StreamWriter writer = new StreamWriter(stream)) {
    //             writer.Write(References.ObjectFormat, cls.Replace(" ", null));
    //         }
    //     });
    // }
}