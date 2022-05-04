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

        return;
        // GLRegistry registry;
        // Stopwatch sw;

        // Console.WriteLine("Parsing registry xml '{0}'", References.XmlFilename);
        // sw = Stopwatch.StartNew();
        // registry = GLRegistry.ParseRegistry(References.XmlFilename);
        // sw.Stop();
        // Console.WriteLine("Parse completed in '{0}'", sw.ToString());

        // Console.WriteLine("Updating registry references");
        // sw = Stopwatch.StartNew();
        // registry.Update();
        // sw.Stop();
        // Console.WriteLine("Update completed in '{0}'", sw.ToString());

        // Console.WriteLine("Generating registry bindings");
        // sw = Stopwatch.StartNew();
        // Generator.WriteRegistry(registry);
        // sw.Stop();
        // Console.WriteLine("Generation completed in '{0}'", sw.ToString());
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

        SortedDictionary<string, List<GLenumerant>> usedEnumValuesMap = new();
        SortedDictionary<string, List<GLcommand>> usedCommandsMap = new();

        List<GLenumerant> usedFeatureEnumValues = new();
        List<GLcommand> usedFeatureCommands = new();
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

        List<GLenumerant> usedExtensionEnumValues = new();
        List<GLcommand> usedExtensionCommands = new();
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

            WriteFeatureConstants(registry, feature, headerGuard, usedFeatureEnumValues, usedEnumValuesMap);
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
        foreach(GLdepends require in feature.Require) {
            foreach(GLreference<GLenumerant> reference in require.Enumerants) {
                GLenumerant enumerant = reference.Reference;
                if (!usedEnumerants.Contains(enumerant) && ! enumerants.Contains(enumerant)) {
                    usedEnumerants.Add(enumerant);
                    enumerants.Add(enumerant);
                }
            }
        }
        enumerants.Sort((x, y) => 
            Convert.ToUInt64(x.Value, 16).CompareTo(
            Convert.ToUInt64(y.Value, 16)
        ));

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

                string ihGuard = "";
                foreach (string api in apis) {
                    ihGuard += string.Format("!{0} && ", api);
                }
                if (!string.IsNullOrEmpty(ihGuard)) {
                    ihGuard = ihGuard.Substring(0, ihGuard.LastIndexOf(" && "));
                    if (apis.Count > 1) {
                        ihGuard = "(" + ihGuard + ")";
                    }
                }

                string type = "GLenum";
                if (value.Name.EndsWith("_BIT") || value.Name.EndsWith("_BITS")) {
                    type = "GLbitfield";
                } else if (value.Name == "GL_TIMEOUT_IGNORED") {
                    type = "GLuint64";
                }

                if (!string.IsNullOrEmpty(ihGuard)) {
                    writer.WriteLine("\n#if {0}", ihGuard);
                }

                writer.Write(Resources.ConstantsDefinition, value.Name, value.Value, type);

                if (!string.IsNullOrEmpty(ihGuard)) {
                    writer.WriteLine("\n#endif");
                }
            }
            writer.Write(Resources.ConstantsFooter);
        }
        Console.WriteLine("File written: {0}", constFilename);
    }
}