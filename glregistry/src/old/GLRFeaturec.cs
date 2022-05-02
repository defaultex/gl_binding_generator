namespace glregistry;

public class GLRFeature : ICloneable {
    GLRegistry m_registry;
    List<string> m_reqTypes, m_reqEnums, m_reqCommands, m_remEnums, m_remCommands;
    List<string> m_types;
    List<GLREnumerant> m_enums;
    List<GLRCommand> m_commands;

    /// <summary>
    /// API name this feature is for.
    /// </summary>
    public string API;
    /// <summary>
    /// Name of the feature.
    /// </summary>
    public string Name;
    /// <summary>
    /// Major and minor version numbers.
    /// </summary>
    public string Number;
    /// <summary>
    /// A list of types that are required by this feature.
    /// </summary>
    public IReadOnlyList<string> RequiredTypes { get => m_reqTypes; }
    /// <summary>
    /// A list of enumerants that are required by this feature.
    /// </summary>
    public IReadOnlyList<string> RequireEnums { get => m_reqEnums; }
    /// <summary>
    /// A list of commands that are required by this feature.
    /// </summary>
    public IReadOnlyList<string> RequireCommands { get => m_reqCommands; }
    /// <summary>
    /// A list of enumerants that are removed by this feature.
    /// </summary>
    public IReadOnlyList<string> RemoveEnums { get => m_remEnums; }
    /// <summary>
    /// A list of commands that are removed by this feature.
    /// </summary>
    public IReadOnlyList<string> RemoveCommands { get => m_remCommands; }

    /// <summary>
    /// Types that are required for this feature.
    /// </summary>
    public IReadOnlyList<string> Types { get => m_types; }
    /// <summary>
    /// Enumerants that are required for this feature.
    /// </summary>
    public IReadOnlyList<GLREnumerant> Enums { get => m_enums; }
    /// <summary>
    /// Commands that are required for this feature.
    /// </summary>
    public IReadOnlyList<GLRCommand> Commands { get => m_commands; }

    public GLRFeature() {
        m_reqTypes = new();
        m_reqEnums = new();
        m_reqCommands = new();
        m_remEnums = new();
        m_remCommands = new();
        m_types = new();
        m_enums = new();
        m_commands = new();
    }

    /// <summary>
    /// Check if a required type exists within this feature.
    /// </summary>
    /// <param name="typeName">Name of the type to look for.</param>
    /// <returns>True if the require type list contains the specified type, false if it does not.</returns>
    public bool ContainsRequireType(string typeName) => m_reqTypes.Contains(typeName);
    /// <summary>
    /// Check if a required enumerant exists within this feature.
    /// </summary>
    /// <param name="enumName">Name of the enumerant to look for.</param>
    /// <returns>True if the require enum list contains the specified enumerant, false if it does not.</returns>
    public bool ContainsRequireEnum(string enumName) => m_reqEnums.Contains(enumName);
    /// <summary>
    /// Check if a required command exists within this feature.
    /// </summary>
    /// <param name="commandName">Name of the command to look for.</param>
    /// <returns>True if the require command list contains the specified command, false if it does not.</returns>
    public bool ContainsRequireCommand(string commandName) => m_reqCommands.Contains(commandName);
    /// <summary>
    /// Check if a remove enumerant exists within this feature.
    /// </summary>
    /// <param name="enumName">Name of the enumerant to look for.</param>
    /// <returns>True if the remove enum list contains the specified enumerant, false if it does not.</returns>
    public bool ContainsRemoveEnum(string enumName) => m_remEnums.Contains(enumName);
    /// <summary>
    /// Check if a remove command exists within this feature.
    /// </summary>
    /// <param name="commandName">Name of the command to look for.</param>
    /// <returns>True if the remove command list contains the specified command, false if it does not.</returns>
    public bool ContainsRemoveCommand(string commandName) => m_remCommands.Contains(commandName);

    /// <summary>
    /// Add one or more types to the require types list, ignores duplicates.
    /// </summary>
    /// <param name="types">One or more types to be added.</param>
    /// <returns>Amount of types that were added.</returns>
    public int AddRequireTypes(params string[] types) {
        if (types != null) {
            string[] matches = Array.FindAll(types, (x) => !ContainsRequireType(x));
            m_reqTypes.AddRange(matches);
            return (matches != null) ? matches.Length : 0;
        }
        return 0;
    }
    /// <summary>
    /// Add one or more enums to the require enums list, ignores duplicates.
    /// </summary>
    /// <param name="enums">One or more enums to be added.</param>
    /// <returns>Amount of enums that were added.</returns>
    public int AddRequireEnums(params string[] enums) {
        if (enums != null) {
            string[] matches = Array.FindAll(enums, (x) => !ContainsRequireEnum(x));
            m_reqEnums.AddRange(matches);
            return (matches != null) ? matches.Length : 0;
        }
        return 0;
    }
    /// <summary>
    /// Add one or more commands to the require commands list, ignores duplicates.
    /// </summary>
    /// <param name="commands">One or more commands to be added.</param>
    /// <returns>Amount of commands that were added.</returns>
    public int AddRequireCommands(params string[] commands) {
        if (commands != null) {
            string[] matches = Array.FindAll(commands, (x) => !ContainsRequireCommand(x));
            m_reqCommands.AddRange(matches);
            return (matches != null) ? matches.Length : 0;
        }
        return 0;
    }
    /// <summary>
    /// Add one or more enums to the remove enums list, ignores duplicates.
    /// </summary>
    /// <param name="enums">One or more enums to be added.</param>
    /// <returns>Amount of enums that were added.</returns>
    public int AddRemoveEnums(params string[] enums) {
        if (enums != null) {
            string[] matches = Array.FindAll(enums, (x) => !ContainsRemoveEnum(x));
            m_remEnums.AddRange(matches);
            return (matches != null) ? matches.Length : 0;
        }
        return 0;
    }
    /// <summary>
    /// Add one or more commands to the remove commands list, ignores duplicates.
    /// </summary>
    /// <param name="commands">One or more commands to be added.</param>
    /// <returns>Amount of commands that were added.</returns>
    public int AddRemoveCommands(params string[] commands) {
        if (commands != null) {
            string[] matches = Array.FindAll(commands, (x) => !ContainsRemoveCommand(x));
            m_remCommands.AddRange(matches);
            return (matches != null) ? matches.Length : 0;
        }
        return 0;
    }

    /// <summary>
    /// Remove one or more types from the require types list.
    /// </summary>
    /// <param name="types">One or more types to be removed.</param>
    /// <returns>Amount of types that were removed.</returns>
    public int RemoveRequireTypes(params string[] types) {
        if (types != null) {
            return m_reqTypes.RemoveAll((x) => Array.Exists(types, ContainsRequireType));
        }
        return 0;
    }
    /// <summary>
    /// Remove one or more enums from the require enums list.
    /// </summary>
    /// <param name="enums">One or more enums to be removed.</param>
    /// <returns>Amount of enums that were removed.</returns>
    public int RemoveRequireEnums(params string[] enums) {
        if (enums != null) {
            return m_reqEnums.RemoveAll((x) => Array.Exists(enums, ContainsRequireEnum));
        }
        return 0;
    }
    /// <summary>
    /// Remove one or more commands from the require commands list.
    /// </summary>
    /// <param name="commands">One or more commands to be removed.</param>
    /// <returns>Amount of commands that were removed.</returns>
    public int RemoveRequireCommands(params string[] commands) {
        if (commands != null) {
            return m_reqCommands.RemoveAll((x) => Array.Exists(commands, ContainsRequireCommand));
        }
        return 0;
    }
    /// <summary>
    /// Remove one or more enums from the remove enums list.
    /// </summary>
    /// <param name="enums">One or more enums to be removed.</param>
    /// <returns>Amount of enums that were removed.</returns>
    public int RemoveRemoveEnums(params string[] enums) {
        if (enums != null) {
            return m_remEnums.RemoveAll((x) => Array.Exists(enums, ContainsRemoveEnum));
        }
        return 0;
    }
    /// <summary>
    /// Remove one or more commands from the remove commands list.
    /// </summary>
    /// <param name="commands">One or more commands to be removed.</param>
    /// <returns>Amount of commands that were removed.</returns>
    public int RemoveRemoveCommands(params string[] commands) {
        if (commands != null) {
            return m_remCommands.RemoveAll((x) => Array.Exists(commands, ContainsRemoveCommand));
        }
        return 0;
    }

    /// <summary>
    /// Update this feature's references to the specified registry.
    /// </summary>
    /// <param name="registry">The registry to fetch references from.</param>
    public void Update(GLRegistry registry) {
        m_registry = registry;

        m_types.Clear();
        m_types.AddRange(
            from regType in registry.Types
            where m_reqTypes.Contains(regType)
            select regType
        );

        m_enums.Clear();
        m_enums.AddRange(
            from enumGroup in registry.EnumGroups
            from enumerant in enumGroup.Enums
            where m_reqEnums.Contains(enumerant.Name)
            select enumerant
        );

        m_commands.Clear();
        m_commands.AddRange(
            from command in registry.Commands
            where m_reqCommands.Contains(command.Name)
            select command
        );
    }

    public static void ParseFeatures(GLRegistry registry, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string api = GLRegistry.ParseString(nav.Select("./@api"));
            string name = GLRegistry.ParseString(nav.Select("./@name"));
            string number = GLRegistry.ParseString(nav.Select("./@number"));
            GLRFeature feature = new() {
                API = api,
                Name = name,
                Number = number
            };
            registry.Features.Add(feature);

            XPathNodeIterator rit = nav.Select("./require");
            while (rit != null && rit.MoveNext()) {
                XPathNavigator rnav = rit.Current.CreateNavigator();
                string profile = GLRegistry.ParseString(rnav.Select("./@profile"));
                if (!string.IsNullOrEmpty(profile) && !profile.Equals("compatibility")) {
                    ParseName(feature.m_reqTypes, rnav.Select("./type"));
                    ParseName(feature.m_reqEnums, rnav.Select("./enum"));
                    ParseName(feature.m_reqCommands, rnav.Select("./command"));
                } else if (string.IsNullOrEmpty(profile)) {
                    ParseName(feature.m_reqTypes, rnav.Select("./type"));
                    ParseName(feature.m_reqEnums, rnav.Select("./enum"));
                    ParseName(feature.m_reqCommands, rnav.Select("./command"));
                }
            }
            ParseName(feature.m_remCommands, nav.Select("./remove/command"));
            ParseName(feature.m_remEnums, nav.Select("./remove/enum"));
        }
    }

    static void ParseName(List<string> output, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string name = GLRegistry.ParseString(nav.Select("./@name"));
            if (!output.Exists((x) => x.Equals(name))) {
                output.Add(name);
            }
        }
    }

    public object Clone() {
        GLRFeature result = new() {
            API = !string.IsNullOrEmpty(API) ? API.Clone() as string : API,
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Number = !string.IsNullOrEmpty(Number) ? Number.Clone() as string : Number
        };
        result.m_reqEnums.AddRange(m_reqEnums);
        result.m_reqEnums.TrimExcess();
        result.m_reqCommands.AddRange(m_reqCommands);
        result.m_reqCommands.TrimExcess();
        result.m_reqTypes.AddRange(m_reqTypes);
        result.m_reqTypes.TrimExcess();
        result.m_remEnums.AddRange(m_remEnums);
        result.m_remEnums.TrimExcess();
        result.m_remCommands.AddRange(m_remCommands);
        result.m_remCommands.TrimExcess();
        return result;
    }

    public override string ToString() => Name;
}
