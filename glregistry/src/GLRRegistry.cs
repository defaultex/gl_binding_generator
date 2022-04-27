
public class GLRegistry {
    public string Comment;
    public List<string> Types;
    public List<GLREnumGroup> EnumGroups;
    public List<GLRCommand> Commands;
    public List<GLRFeature> Features;
    public List<GLRExtension> Extensions;

    public List<string> Classes;
    public List<GLREnumValue> MasterValues;
    public List<GLREnumGroup> MasterGroups;

    public GLRegistry(string comment) {
        Comment = comment;
        Types = new();
        EnumGroups = new();
        Classes = new();
        EnumGroups = new();
        Commands = new();
        Features = new();
        Extensions = new();
        MasterGroups = new();
        MasterValues = new();
    }

    public void Update() {
        UpdateMaster();
        UpdateClasses();

        foreach (GLRFeature feature in Features) {
            feature.Update(this);
        }
        foreach (GLRExtension extension in Extensions) {
            extension.Update(this);
        }

        Types.Sort((x, y) => x.CompareTo(y));
        Classes.Sort((x, y) => x.CompareTo(y));
        EnumGroups.Sort((x, y) => x.Name.CompareTo(y.Name));
        Commands.Sort((x, y) => x.Name.CompareTo(y.Name));
        Features.Sort((x, y) => x.Name.CompareTo(y.Name));
        Extensions.Sort((x, y) => x.Name.CompareTo(y.Name));
        MasterGroups.Sort((x, y) => x.Name.CompareTo(y.Name));
        MasterValues.Sort((x, y) => x.Name.CompareTo(y.Name));
    }

    void UpdateMaster() {
        MasterValues = new();
        MasterGroups = new();

        foreach (GLREnumGroup srcGroup in EnumGroups) {
            GLREnumGroup outGroup = MasterGroups.Find((x) => x.Name == srcGroup.Name);
            if (outGroup == null) {
                outGroup = new() {
                    Name = srcGroup.Name,
                    Type = srcGroup.Type,
                    // Vendor = srcGroup.Vendor,
                    // Start = srcGroup.Start,
                    // End = srcGroup.End
                };
                MasterGroups.Add(outGroup);
            }

            foreach (GLREnumValue srcValue in srcGroup.Values) {
                // try to fetch the value from the master values list
                GLREnumValue outValue = MasterValues.Find((v) => v.Name == srcValue.Name);
                if (outValue == null) {
                    // create a new value since it was not found
                    outValue = new() {
                        Name = srcValue.Name,
                        Value = srcValue.Value
                    };
                    MasterValues.Add(outValue);
                }

                // merge group definitions
                outValue.Groups.AddRange(srcValue.Groups.FindAll((v) => !outValue.Groups.Exists(v.Equals)));
                outValue.Groups.Remove("Boolean");
                outValue.Groups.TrimExcess();

                // add the enum value to the group if it isn't already present
                if (!outGroup.Values.Exists(outValue.Equals)) {
                    outGroup.Values.Add(outValue);
                }
            }
        }

        foreach (GLREnumValue srcValue in MasterValues) {
            foreach (string groupName in srcValue.Groups) {
                if (string.IsNullOrEmpty(groupName)) {
                    continue;
                }

                // try to fetch the group from the master group list
                GLREnumGroup outGroup = MasterGroups.Find((g) => g.Name == groupName);
                if (outGroup == null) {
                    // create a new group since it was not found
                    outGroup = new() {
                        Name = groupName,
                        Type = "GLenum"
                    };
                    MasterGroups.Add(outGroup);
                }

                // try to fetch the value from stored references
                GLREnumValue outValue = outGroup.Values.Find((v) => v.Name == srcValue.Name);
                if (outValue == null) {
                    // try to fetch the value from the master value list
                    outValue = MasterValues.Find((v) => v.Name == srcValue.Name);
                    if (outValue == null) {
                        // create a new value since it was not found
                        outValue = new() {
                            Name = srcValue.Name,
                            Value = srcValue.Value
                        };

                        // merge the groups list into the out value if possible
                        outValue.Groups.AddRange(srcValue.Groups.FindAll((v) => !outValue.Groups.Exists(v.Equals)));
                        outValue.Groups.TrimExcess();
                    }

                    // add the enum value to the group if it isn't already present
                    if (!outGroup.Values.Exists(outValue.Equals)) {
                        outGroup.Values.Add(outValue);
                    }
                }
            }
        }

        MasterValues.TrimExcess();
        MasterGroups.TrimExcess();
    }

    void UpdateClasses() {
        Classes = new();
        foreach (GLRCommand command in Commands) {
            foreach (GLRCommandParam param in command.Params) {
                if (!string.IsNullOrEmpty(param.Class) && !Classes.Exists(param.Class.Equals)) {
                    Classes.Add(param.Class.Clone() as string);
                }
            }
        }
    }

    internal static string ParseString(XPathNodeIterator it) => ((it != null && it.MoveNext()) ? it.Current.Value : null);

    public static GLRegistry ParseRegistry(string xmlPath) {
        if (!File.Exists(xmlPath)) {
            return null;
        }

        GLRegistry registry = null;
        XPathDocument document = new XPathDocument(xmlPath);
        XPathNavigator nav = document.CreateNavigator();

        // move into the root 'registry' node
        XPathNodeIterator it = nav.Select("./registry");
        if (it.MoveNext()) {
            nav = it.Current.CreateNavigator();
        }

        string comment = ParseString(nav.Select("./comment"));
        registry = new(comment);
        ParseTypes(registry, nav.Select("./types/type"));
        GLREnumGroup.ParseEnumGroups(registry, nav.Select("./enums"));
        GLRCommand.ParseCommands(registry, nav.Select("./commands/command"));
        GLRFeature.ParseFeatures(registry, nav.Select("./feature"));
        GLRExtension.ParseExtensions(registry, nav.Select("./extensions/extension"));
        return registry;
    }

    static void ParseTypes(GLRegistry registry, XPathNodeIterator it) {
        while (it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string name = ParseString(nav.Select("./name"));
            if (string.IsNullOrEmpty(name)) {
                continue;
            }
            name = name.Trim();

            if (!registry.Types.Exists(name.Equals)) {
                registry.Types.Add(name);
            }
        }
        registry.Types.TrimExcess();
    }
}
