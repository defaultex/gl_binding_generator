namespace glregistry;

public static class Generator {

    public static string CreateHeaderGuard(IList<string> apis, string sep = "||", bool invertFirst = true) {
        string hguard = string.Empty;
        int acount = apis.Count;
        for (int i = 0; i < acount; i++) {
            if (i < acount - 1) {
                if (invertFirst) {
                    hguard += string.Format("!{0} {1} ", apis[i], sep);
                } else {
                    hguard += string.Format("{0} {1} ", apis[i], sep);
                }
            } else {
                if (invertFirst) {
                    hguard += string.Format("!{0}", apis[i]);
                } else {
                    hguard += string.Format("{0}", apis[i]);
                }
            }
        }
        if (!string.IsNullOrEmpty(hguard) && apis.Count > 1) {
            hguard = string.Format("({0})", hguard);
        }
        return hguard;
    }

    public static int CompareEnumerants(GLenumerant x, GLenumerant y) {
        long xval = x.Value.Contains('-') ? Convert.ToInt64(x.Value) : Convert.ToInt64(x.Value, 16);
        long yval = y.Value.Contains('-') ? Convert.ToInt64(y.Value) : Convert.ToInt64(y.Value, 16);
        int xycomp = xval.CompareTo(yval);
        // when values are equal, compare on name
        return (xycomp == 0) ? x.Name.CompareTo(y.Name) : xycomp;
    }

    public static void WriteRegistry(GLregistry registry) {
        // regenerate the output directory then write all the files based on the above filters
        if (Directory.Exists(Resources.OutputFolder)) {
            Directory.Delete(Resources.OutputFolder, true);
            Console.WriteLine("Deleted directory: {0}", Resources.OutputFolder);
        }

        Directory.CreateDirectory(Resources.OutputFolder);
        Console.WriteLine("Created directory: {0}", Resources.OutputFolder);

        Directory.CreateDirectory(Resources.EnumFolder);
        Console.WriteLine("Created directory: {0}", Resources.EnumFolder);

        WriteGitignore();
        WriteCSProj();
        WriteUsings(registry);
        WriteClasses(registry);

        SortedDictionary<string, List<GLenumerant>> usedEnumerantsMap = new();
        SortedDictionary<string, List<GLcommand>> usedCommandsMap = new();
        List<GLgroup> allUsedGroups = new();

        List<GLenumerant> usedFeatureEnumerants = new();
        List<GLcommand> usedFeatureCommands = new();
        foreach (GLfeature feature in registry.Features) {
            if (!usedEnumerantsMap.TryGetValue(feature.API, out usedFeatureEnumerants)) {
                usedFeatureEnumerants = new();
                usedEnumerantsMap.Add(feature.API, usedFeatureEnumerants);
            }
            if (!usedCommandsMap.TryGetValue(feature.API, out usedFeatureCommands)) {
                usedFeatureCommands = new();
                usedCommandsMap.Add(feature.API, usedFeatureCommands);
            }
        }

        List<GLenumerant> usedExtensionEnumerants = new();
        List<GLcommand> usedExtensionCommands = new();
        foreach (GLextension extension in registry.Extensions) {
            if (!usedEnumerantsMap.TryGetValue(extension.SupportedAPIs[0], out usedExtensionEnumerants)) {
                usedExtensionEnumerants = new();
                usedEnumerantsMap.Add(extension.SupportedAPIs[0], usedExtensionEnumerants);
            }
            if (!usedCommandsMap.TryGetValue(extension.SupportedAPIs[0], out usedExtensionCommands)) {
                usedExtensionCommands = new();
                usedCommandsMap.Add(extension.SupportedAPIs[0], usedExtensionCommands);
            }
        }

        foreach (GLfeature feature in registry.Features) {
            string headerGuard = string.Format("({0} && {1}_API)", feature.Name, feature.API.ToUpper());
            string featureFolder = string.Format(Resources.FeatureFolder, feature.Name);
            string featureEnumFolder = string.Format(Resources.FeatureEnumFolder, feature.Name);

            if (!Directory.Exists(featureFolder)) {
                Directory.CreateDirectory(featureFolder);
                Console.WriteLine("Created directory: {0}", featureFolder);
            }
            if (!Directory.Exists(featureEnumFolder)) {
                Directory.CreateDirectory(featureEnumFolder);
                Console.WriteLine("Created directory: {0}", featureEnumFolder);
            }

            WriteFeatureConstants(registry, feature, headerGuard, usedFeatureEnumerants, usedEnumerantsMap);
            WriteFeatureCommands(registry, feature, headerGuard, usedFeatureCommands, usedCommandsMap, allUsedGroups);
        }

        foreach (GLextension extension in registry.Extensions) {
            string headerGuard = CreateHeaderGuard(extension.SupportedAPIs, "||");
            if (!string.IsNullOrEmpty(headerGuard)) {
                headerGuard = string.Format("({0} && {1})", extension.Name, headerGuard);
            } else {
                headerGuard = extension.Name;
            }

            string extFolder = extension.Ext + "/" + extension.Name;
            string extensionFolder = string.Format(Resources.ExtensionFolder, extFolder);
            if (!Directory.Exists(extensionFolder)) {
                Directory.CreateDirectory(extensionFolder);
                Console.WriteLine("Created directory: {0}", extensionFolder);
            }

            string extensionEnumFolder = string.Format(Resources.ExtEnumFolder, extFolder);
            if (!Directory.Exists(extensionEnumFolder)) {
                Directory.CreateDirectory(extensionEnumFolder);
                Console.WriteLine("Created directory: {0}", extensionEnumFolder);
            }

            WriteExtensionConstants(registry, extension, headerGuard, usedExtensionEnumerants, usedEnumerantsMap);
            WriteExtensionCommands(registry, extension, headerGuard, usedExtensionCommands, usedCommandsMap, allUsedGroups);
        }

        allUsedGroups.Sort((x, y) => x.Name.CompareTo(y.Name));

        // clean up the used group list
        List<string> usedGroupsToRemove = new();
        usedGroupsToRemove.Add("Boolean");
        foreach (string groupName in Resources.MergeGroups.Keys) {
            string newGroupName = Resources.MergeGroups[groupName];

            // try to fetch an existing group for the merge source
            GLgroup group = allUsedGroups.Find(groupName);
            if (group == null) {
                continue;
            }
            if (groupName != newGroupName && !usedGroupsToRemove.Contains(groupName)) {
                usedGroupsToRemove.Add(groupName);
            }

            // try to fetch an existing group for the merge target
            GLgroup newGroup = allUsedGroups.Find(newGroupName);
            if (newGroup == null) {
                newGroup = new() {
                    Name = Resources.MergeGroups[groupName],
                    Type = group.Type
                };
                allUsedGroups.Add(newGroup);
            }

            // merge the values of the source into the target
            foreach (GLenumerant value in group.Enumerants) {
                GLenumerant newValue = newGroup.Enumerants.Find(value.Name);
                if (newValue == null) {
                    newValue = new() {
                        Name = value.Name,
                        Value = value.Value
                    };
                    newGroup.AddEnums(newValue);
                    newValue.UpdateReferences(registry);
                    newValue.UpdateCode();
                }

                foreach (string valGroupName in value.Groups) {
                    if (!newValue.Groups.Contains(valGroupName)) {
                        newValue.AddGroups(valGroupName);
                    }
                }
            }
        }

        foreach (string groupName in usedGroupsToRemove) {
            GLgroup group = allUsedGroups.Find(groupName);
            if (group != null) {
                allUsedGroups.Remove(group);
            }
        }

        WriteEnums(registry, allUsedGroups, usedEnumerantsMap);
    }

    static void WriteFeatureConstants(GLregistry registry, GLfeature feature, string ohGuard,
        List<GLenumerant> usedEnumerants, SortedDictionary<string, List<GLenumerant>> usedEnumerantsMap) {

        List<GLenumerant> enumerants = new();
        foreach (GLdepends require in feature.Require) {
            foreach (GLreference<GLenumerant> reference in require.Enumerants) {
                GLenumerant enumerant = reference.Reference;
                if (!usedEnumerants.Contains(reference.Name)) {
                    usedEnumerants.Add(enumerant);
                    enumerants.Add(enumerant);
                }
            }
        }

        if (enumerants.Count < 1) {
            return;
        }
        enumerants.Sort(CompareEnumerants);

        // write constants for each of the enumerant required by the feature
        string constFilename = string.Format(Resources.ConstantsFilename, feature.Name);
        using (FileStream stream = File.OpenWrite(constFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(Resources.ConstantsHeader, ohGuard, feature.API);
            foreach (GLenumerant value in enumerants) {
                string ihGuard;
                if (string.IsNullOrEmpty(value.HeaderGuard)) {
                    ihGuard = string.Format("({0} && !{1})", value.FirstOccurence, value.HeaderGuard);
                } else {
                    ihGuard = value.FirstOccurence;
                }

                ihGuard = null;

                if (!string.IsNullOrEmpty(ihGuard)) {
                    writer.WriteLine("\n#if {0}", ihGuard);
                    writer.WriteLine(value.CSDecl);
                    writer.WriteLine("\n#endif");
                } else {
                    writer.WriteLine(value.CSDecl);
                }
            }
            writer.Write(Resources.ConstantsFooter);
        }
        Console.WriteLine("File written: {0}", constFilename);
    }

    static void WriteFeatureCommands(GLregistry registry, GLfeature feature, string ohGuard,
        List<GLcommand> usedCommands, SortedDictionary<string, List<GLcommand>> usedCommandsMap, List<GLgroup> usedGroups) {
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
                foreach (GLprototype param in command.Parameters) {
                    if (param.GroupRef != null && !string.IsNullOrEmpty(param.Group) && !usedGroups.Contains(param.GroupRef)) {
                        usedGroups.Add(param.GroupRef);
                    }
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
                string ihGuard = CreateHeaderGuard(listedInFeatures);

                ihGuard = null;

                if (!string.IsNullOrEmpty(ihGuard)) {
                    writer.Write("\n#if {0}", ihGuard);
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
        enumerants.Sort(CompareEnumerants);

        // write constants for each of the enerantlues required by the feature
        string constFilename = string.Format(Resources.ExtConstantsFilename, extension.Ext + "/" + extension.Name);
        using (FileStream stream = File.OpenWrite(constFilename))
        using (StreamWriter writer = new StreamWriter(stream)) {
            writer.Write(Resources.ConstantsHeader, ohGuard, extension.SupportedAPIs[0]);
            foreach (GLenumerant value in enumerants) {
                string ihGuard = string.Format("({0} && !{1})", value.FirstOccurence, value.HeaderGuard);
                if (string.IsNullOrEmpty(value.HeaderGuard)) {
                    ihGuard = string.Format("({0} && !{1})", value.FirstOccurence, value.HeaderGuard);
                } else {
                    ihGuard = value.FirstOccurence;
                }

                ihGuard = null;

                if (!string.IsNullOrEmpty(ihGuard)) {
                    writer.WriteLine("\n#if {0}", ihGuard);
                    writer.WriteLine(value.CSDecl);
                    writer.WriteLine("\n#endif");
                } else {
                    writer.WriteLine(value.CSDecl);
                }
            }
            writer.Write(Resources.ConstantsFooter);
        }
        Console.WriteLine("File written: {0}", constFilename);
    }

    static void WriteExtensionCommands(GLregistry registry, GLextension extension, string ohGuard,
        List<GLcommand> usedCommands, SortedDictionary<string, List<GLcommand>> usedCommandsMap, List<GLgroup> usedGroups) {

        List<GLcommand> commands = new();
        foreach (GLdepends dependency in extension.Require) {
            foreach (GLreference<GLcommand> reference in dependency.Commands) {
                GLcommand command = reference.Reference;
                if (!usedCommands.Contains(command)) {
                    usedCommands.Add(command);
                    commands.Add(command);

                    foreach (GLprototype param in command.Parameters) {
                        if (param.GroupRef != null && !string.IsNullOrEmpty(param.Group) && !usedGroups.Contains(param.GroupRef)) {
                            usedGroups.Add(param.GroupRef);
                        }
                    }
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
                string ihGuard = CreateHeaderGuard(listedInFeatures);

                ihGuard = null;

                if (!string.IsNullOrEmpty(ihGuard)) {
                    writer.Write("\n#if {0}", ihGuard);
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

    static void WriteEnums(GLregistry registry, List<GLgroup> allUsedGroups, SortedDictionary<string, List<GLenumerant>> usedEnumerantsMap) {

        foreach (GLgroup group in allUsedGroups) {

            List<string> allAPIs = new();
            foreach (GLenumerant value in group.Enumerants) {
                foreach (string key in usedEnumerantsMap.Keys) {
                    List<GLenumerant> enumValues = usedEnumerantsMap[key];
                    if (enumValues.Exists((x) => x.Name == value.Name) && !allAPIs.Exists(key.Equals)) {
                        allAPIs.Add(key);
                    }
                }
            }

            string headerGuard = string.Empty;
            if (!string.IsNullOrEmpty(group.HeaderGuard)) {
                headerGuard = string.Format("({0} && !{1})", group.FirstOccurence, group.HeaderGuard);
            } else {
                headerGuard = group.FirstOccurence;
            }

            string outGroupName = group.Name;
            string enumFilename = string.Format(Resources.EnumFilename, outGroupName);

            string outExt = Regex.Match(outGroupName, "[A-Z][A-Z]+").Value;
            if (outExt == "PN") {
                outExt = Regex.Match(outGroupName, "[A-Z][A-Z][A-Z]+").Value;
            }

            if (registry.Extensions.Any(x => x.Ext == outExt)) {
                enumFilename = string.Format(Resources.ExtEnumFilename, outExt, outGroupName);
            } else if (allAPIs.Count == 1) {
                GLextension ext = registry.Extensions.Find(allAPIs[0]);
                if (ext != null) {
                    enumFilename = string.Format(Resources.ExtEnumFilename, ext.Ext, outGroupName);
                } else {
                    enumFilename = string.Format(Resources.FeatureEnumFilename, allAPIs[0], outGroupName);
                }
            }

            int lastSlashIndex = enumFilename.LastIndexOf('/');
            string enumPath = enumFilename.Substring(0, lastSlashIndex);
            if (!Directory.Exists(enumPath)) {
                Directory.CreateDirectory(enumPath);
                Console.WriteLine("Created directory: {0}", enumPath);
            }


            using (FileStream stream = File.OpenWrite(enumFilename))
            using (StreamWriter writer = new StreamWriter(stream)) {
                string type = group.Name.EndsWith("Mask") ? "GLbitfield" : "GLenum";

                if (!string.IsNullOrEmpty(headerGuard)) {
                    writer.WriteLine("#if {0}\n", headerGuard);
                }
                writer.WriteLine(group.CSDecl);
                // if (type == "GLbitfield") {
                //     writer.Write("\n[Flags]");
                // }

                // writer.WriteLine(Resources.EnumHeader, outGroupName, type);
                // if (type.Equals("GLbitfield")) {
                //     // need a none value for flags enum usability
                //     writer.Write("\n    None = 0,");
                // }

                // foreach (GLenumerant value in group.Enumerants) {
                //     string name = value.CSName;
                //     if (string.IsNullOrEmpty(name)) {
                //         continue;
                //     }

                //     string ihGuard = string.Empty;
                //     if (!string.IsNullOrEmpty(group.HeaderGuard)) {
                //         ihGuard = string.Format("({0} && !{1})", group.FirstOccurence, group.HeaderGuard);
                //     } else {
                //         ihGuard = group.FirstOccurence;
                //     }

                //     if (!string.IsNullOrEmpty(ihGuard)) {
                //         writer.WriteLine("#if {0}", ihGuard);
                //         writer.WriteLine(value.CSDecl);
                //         writer.WriteLine("#endif\n");
                //     } else {
                //         writer.WriteLine(value.CSDecl);
                //     }
                // }
                //writer.Write(Resources.EnumFooter);
                if (!string.IsNullOrEmpty(group.HeaderGuard)) {
                    writer.WriteLine("\n#endif");
                }
            }
            Console.WriteLine("File written: {0}", enumFilename);
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
}