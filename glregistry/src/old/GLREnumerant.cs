namespace glregistry;

public class GLREnumerant : ICloneable {
    GLRegistry m_registry;
    List<string> m_groups;
    GLREnumerant m_aliasedValue;
    List<GLRGroup> m_enumGroups;

    /// <summary>
    /// Value of the enumerant, a C-style constant.
    /// </summary>
    public string Value;
    /// <summary>
    /// Name of the enumerant.
    /// </summary>
    public string Name;
    /// <summary>
    /// An API name that specializes the enumerant so that different APIs may have
    /// different values for the same enumerant.
    /// </summary>
    public string API;
    /// <summary>
    /// C-specific type for the enumerant.
    /// </summary>
    public string Type;
    /// <summary>
    /// Name of another enumerant this is an alias for.
    /// </summary>
    public string Alias;
    /// <summary>
    /// Group names the enumerant is found in.
    /// </summary>
    public IReadOnlyList<string> Groups { get => m_groups; }

    /// <summary>
    /// The registry this enumerant fetches it's references from.
    /// </summary>
    public GLRegistry Registry { get => m_registry; }
    /// <summary>
    /// The value this enumerant is an alias for.
    /// </summary>
    public GLREnumerant AliasedValue { get => m_aliasedValue; }
    /// <summary>
    /// A list of groups referenced by the Groups list.
    /// </summary>
    public IReadOnlyList<GLRGroup> GroupList { get => m_enumGroups; }

    public GLREnumerant() {
        m_groups = new();
        m_enumGroups = new();
    }

    /// <summary>
    /// Check if a group exists within this enumerants groups list.
    /// </summary>
    /// <param name="groupName">Name of the group to look for.</param>
    /// <returns>True if the groups contains the specified name, false if it does not.</returns>
    public bool ContainsGroup(string groupName) => m_groups.Contains(groupName);

    /// <summary>
    /// Add one or more groups to the list, ignores duplicates.
    /// </summary>
    /// <param name="groups">One or more groups to be added.</param>
    /// <returns>Amount of groups that were added.</returns>
    public int AddGroups(params string[] groups) {
        if (groups != null) {
            string[] matches = Array.FindAll(groups, (x) => !ContainsGroup(x));
            m_groups.AddRange(matches);
            return (matches != null) ? matches.Length : 0;
        }
        return 0;
    }

    /// <summary>
    /// Remove one or more groups from the list.
    /// </summary>
    /// <param name="groups">One or more groups to be removed.</param>
    /// <returns>Amount of groups that were removed.</returns>
    public int RemoveGroups(params string[] groups) {
        if (groups != null) {
            return m_groups.RemoveAll((x) => Array.Exists(groups, ContainsGroup));
        }
        return 0;
    }

    /// <summary>
    /// Update this enumerant's references to the specified registry.
    /// </summary>
    /// <param name="registry">The registry to fetch references from.</param>
    public void Update(GLRegistry registry) {
        m_registry = registry;
        m_aliasedValue = registry.Enumerants.Find((x) => x.Name == Alias);
        m_enumGroups.Clear();
        m_enumGroups.AddRange(registry.EnumGroups.FindAll((x) => m_groups.Contains(x.Name)));
    }

    public static void ParseEnumValue(GLRGroup enumGroup, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string name = GLRegistry.ParseString(nav.Select("./@name"));
            string value = GLRegistry.ParseString(nav.Select("./@value"));
            string api = GLRegistry.ParseString(nav.Select("./@api"));
            string type = GLRegistry.ParseString(nav.Select("./@type"));
            string groups = GLRegistry.ParseString(nav.Select("./@group"));
            string alias = GLRegistry.ParseString(nav.Select("./@alias"));
            name = (name != null) ? name.Trim() : name;
            groups = (groups != null) ? groups.Trim() : groups;

            if (string.IsNullOrEmpty(name) || enumGroup.ContainsEnum(name)) {
                continue;
            }

            string[] groupArray = !string.IsNullOrEmpty(groups) ?
                (groups.IndexOf(',') >= 0 ? groups.Split(',') : new string[1] { groups }) :
                (new string[0]);

            GLREnumerant enumValue = new() {
                Name = name,
                Value = (value != null) ? value.Trim() : value,
                API = (api != null) ? api.Trim() : api,
                Type = (type != null) ? type.Trim() : type,
                Alias = (type != null) ? alias.Trim() : alias
            };
            enumValue.AddGroups(groupArray);
            enumGroup.AddEnums(enumValue);
        }
    }

    /// <summary>
    /// Clone an enumerant and copy references to the clone.
    /// </summary>
    public object Clone() => Clone(null);

    /// <summary>
    /// Clone an enumerant and update it's references to a new registry. 
    /// If registry is null then the enumerant will copy references to the clone.
    /// </summary>
    /// <param name="registry">The new registry to fetch references from.</param>
    public GLREnumerant Clone(GLRegistry registry) {
        GLREnumerant result = new() {
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Value = !string.IsNullOrEmpty(Value) ? Value.Clone() as string : Value
        };
        result.AddGroups(m_groups.ToArray());

        if (registry != null) {
            result.Update(registry);
        } else {
            result.m_aliasedValue = m_aliasedValue;
            result.m_enumGroups = m_enumGroups;
        }

        return result;
    }

    public override string ToString() => string.Format("{0} = {1}", Name, Value);
}
