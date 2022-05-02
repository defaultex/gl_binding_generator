namespace glregistry;

public class GLenumerant : ICloneable {
    GLregistry m_registry;
    GLenumerant m_aliased;
    List<GLgroup> m_groupsList;
    List<string> m_groupNames = new();

    /// <summary>
    /// Value of the enumerant, a C-style constant.
    /// </summary>
    [XmlAttribute("value")]
    public string Value;
    /// <summary>
    /// Name of the enumerant.
    /// </summary>
    [XmlAttribute("name")]
    public string Name;
    /// <summary>
    /// An API name that specializes the enumerant so that different APIs may have
    /// different values for the same enumerant.
    /// </summary>
    [XmlAttribute("api")]
    public string API;
    /// <summary>
    /// C-specific type for the enumerant.
    /// </summary>
    [XmlAttribute("type")]
    public string Type;
    /// <summary>
    /// One or more group names the enumerant is found in.
    /// </summary>
    [XmlAttribute("group")]
    public string Group {
        get => string.Join(',', m_groupNames);
        set {
            m_groupNames.Clear();
            if (!string.IsNullOrEmpty(value)) {
                if (value.IndexOf(',') >= 0) {
                    m_groupNames.AddRange(value.Split(','));
                } else {
                    m_groupNames.Add(value);
                }
            }
        }
    }
    /// <summary>
    /// Name of another enumerant this is an alias for.
    /// </summary>
    [XmlAttribute("alias")]
    public string Alias;

    /// <summary>
    /// The registry this enumerant fetches it's references from.
    /// </summary>
    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }
    /// <summary>
    /// The value this enumerant is an alias for.
    /// </summary>
    [XmlIgnore]
    public GLenumerant Aliased { get => m_aliased; }
    /// <summary>
    /// A list of groups referenced by the Groups list.
    /// </summary>
    [XmlIgnore]
    public List<GLgroup> GroupsRef { get => m_groupsList; }
    /// <summary>
    /// A list of groups names.
    /// </summary>
    [XmlIgnore]
    public List<string> Groups { get => m_groupNames; }

    /// <summary>
    /// Check if a group exists within this enumerant's groups.
    /// </summary>
    /// <param name="groupName">Name of the group to look for.</param>
    /// <returns>True if the enumerant's groups contains the specified name, false if it does not.</returns>
    public bool ContainsGroup(string groupName) => m_groupNames.Contains(groupName);

    /// <summary>
    /// Add one or more groups to this enumerant, ignores duplicates.
    /// </summary>
    /// <param name="groups">One or more groups to be added.</param>
    /// <returns>Amount of groups that were added.</returns>
    public int AddGroups(params string[] groups) {
        if (groups != null) {
            IEnumerable<string> matches = (from groupName in groups
                                           where !ContainsGroup(groupName)
                                           select groupName);
            m_groupNames.AddRange(matches);
            return (matches != null) ? matches.Count() : 0;
        }
        return 0;
    }

    /// <summary>
    /// Remove one or more groups from this enumerant.
    /// </summary>
    /// <param name="groups">One or more groups to be removed.</param>
    /// <returns>Amount of groups that were removed.</returns>
    public int RemoveGroups(params string[] groups) {
        if (groups != null) {
            return m_groupNames.RemoveAll(groups.Contains);
        }
        return 0;
    }

    /// <summary>
    /// Update the enumerant's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        if (registry != null) {
            // find the first match for the alias name
            m_aliased = (from enumerant in registry.Enumerants
                         where enumerant.Name == Alias
                         select enumerant).FirstOrDefault();
            if (m_aliased != null) {
                // unroll any further aliasing
                while (m_aliased.Aliased != null) {
                    m_aliased = m_aliased.Aliased;
                }
            }

            // find the groups that match the group names
            m_groupsList = registry.Groups.FindAll((x) => ContainsGroup(x.Name));
        } else {
            m_groupsList = null;
            m_aliased = null;
        }
    }

    /// <summary>
    /// Clone this enumerant with existing references.
    /// </summary>
    public object Clone() => Clone(null);

    /// <summary>
    /// Clone this enumerant with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to clone the enumerant into or null for keep references.</param>
    public GLenumerant Clone(GLregistry registry) {
        GLenumerant result = new() {
            Value = Value,
            Name = Name,
            API = API,
            Type = Type,
            Group = Group
        };

        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}