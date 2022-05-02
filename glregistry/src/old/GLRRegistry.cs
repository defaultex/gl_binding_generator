namespace glregistry;

public class GLRegistry {
    public string Comment;
    public List<string> Types;
    public List<GLRGroup> EnumGroups;
    public List<GLRCommand> Commands;
    public List<GLRFeature> Features;
    public List<GLRExtension> Extensions;

    /// <summary>
    /// A list of object classes that exist in the registry.
    /// </summary>
    public List<string> Classes;
    /// <summary>
    /// A list of all enumerants that exist in the registry.
    /// </summary>
    public List<GLREnumerant> Enumerants;
    /// <summary>
    /// A list of all enumerant groups that exist in the registry.
    /// </summary>
    public List<GLRGroup> Groups;

    public GLRegistry(string comment) {
        Comment = comment;
        Types = new();
        EnumGroups = new();
        Classes = new();
        EnumGroups = new();
        Commands = new();
        Features = new();
        Extensions = new();
        Groups = new();
        Enumerants = new();
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
        Groups.Sort((x, y) => x.Name.CompareTo(y.Name));
        Enumerants.Sort((x, y) => x.Name.CompareTo(y.Name));
    }

    void UpdateMaster() {
        Enumerants = new();
        Groups = new();

        foreach (GLRGroup srcGroup in EnumGroups) {
            GLRGroup outGroup = Groups.Find((x) => x.Name == srcGroup.Name);
            if (outGroup == null) {
                outGroup = new() {
                    Name = srcGroup.Name,
                    Type = srcGroup.Type,
                    // Vendor = srcGroup.Vendor,
                    // Start = srcGroup.Start,
                    // End = srcGroup.End
                };
                Groups.Add(outGroup);
            }

            foreach (GLREnumerant srcValue in srcGroup.Enums) {
                // try to fetch the value from the master values list
                GLREnumerant outValue = Enumerants.Find((v) => v.Name == srcValue.Name);
                if (outValue == null) {
                    // create a new value since it was not found
                    outValue = new() {
                        Name = srcValue.Name,
                        Value = srcValue.Value
                    };
                    Enumerants.Add(outValue);
                }

                // merge group definitions
                outValue.AddGroups((from groupName in srcValue.Groups
                                   where !outValue.Groups.Contains(groupName)
                                   select groupName).ToArray());
                outValue.RemoveGroups("Boolean");

                // add the enum value to the group if it isn't already present
                if (!outGroup.ContainsEnum(outValue)) {
                    outGroup.AddEnums(outValue);
                }
            }
        }

        foreach (GLREnumerant srcValue in Enumerants) {
            foreach (string groupName in srcValue.Groups) {
                if (string.IsNullOrEmpty(groupName)) {
                    continue;
                }

                // try to fetch the group from the master group list
                GLRGroup outGroup = Groups.Find((g) => g.Name == groupName);
                if (outGroup == null) {
                    // create a new group since it was not found
                    outGroup = new() {
                        Name = groupName,
                        Type = "GLenum"
                    };
                    Groups.Add(outGroup);
                }

                // try to fetch the value from stored references
                GLREnumerant outValue = (from enumerant in outGroup.Enums
                                         where enumerant.Name == srcValue.Name
                                         select enumerant).FirstOrDefault();
                if (outValue == null) {
                    // try to fetch the value from the master value list
                    outValue = (from enumerant in Enumerants
                                where enumerant.Name == srcValue.Name
                                select enumerant).FirstOrDefault();
                    if (outValue == null) {
                        // create a new value since it was not found
                        outValue = new() {
                            Name = srcValue.Name,
                            Value = srcValue.Value
                        };

                        // merge the groups list into the out value if possible
                        outValue.AddGroups((from srcGroupName in srcValue.Groups
                                            where !outValue.ContainsGroup(srcGroupName)
                                            select srcGroupName).ToArray());
                    }

                    // add the enum value to the group if it isn't already present
                    if (!outGroup.ContainsEnum(outValue)) {
                        outGroup.AddEnums(outValue);
                    }
                }
            }
        }

        Enumerants.TrimExcess();
        Groups.TrimExcess();
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
        GLRGroup.ParseEnumGroups(registry, nav.Select("./enums"));
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
