namespace glregistry;

public class GLgroup : ICloneable {
    GLregistry m_registry;
    List<GLenumerant> m_enumerants = new();

    /// <summary>
    /// Namespace this group is defined for.
    /// </summary>
    [XmlAttribute("namespace")]
    public string Namespace;
    /// <summary>
    /// Name of the group.
    /// </summary>
    [XmlAttribute("group")]
    public string Name;
    /// <summary>
    /// Data type of the values of enumerants in this group.
    /// </summary>
    [XmlAttribute("type")]
    public string Type;
    /// <summary>
    /// Start of the value range to reserve.
    /// </summary>
    [XmlAttribute("start")]
    public string Start;
    /// <summary>
    /// End of the value range to reserve.
    /// </summary>
    [XmlAttribute("end")]
    public string End;
    /// <summary>
    /// A vendor or purpose for the reserved range in start and end.
    /// </summary>
    [XmlAttribute("vendor")]
    public string Vendor;
    /// <summary>
    /// A list of enumerants defined by this group.
    /// </summary>
    [XmlElement("enum")]
    public List<GLenumerant> Enumerants { get => m_enumerants; protected set => m_enumerants = value; }

    /// <summary>
    /// Check if an enumerant exists within this group.
    /// </summary>
    /// <param name="enumName">Name of the enumerant to look for.</param>
    /// <returns>True if the group contains the specified enumerant name, false if it does not.</returns>
    public bool ContainsEnum(string enumName) => m_enumerants.Exists((x) => x.Name == enumName);

    /// <summary>
    /// Check if an enumerant exists within this group.
    /// </summary>
    /// <param name="enumerant">The enumerant to look for.</param>
    /// <returns>True if the group contains the specified enumerant, false if it does not.</returns>
    public bool ContainsEnum(GLenumerant enumerant) => m_enumerants.Contains(enumerant);

    /// <summary>
    /// Add one or more enumerants to this group, ignores duplicates.
    /// </summary>
    /// <param name="enums">One or more enumerants to be added.</param>
    /// <returns>Amount of enumerants that were added.</returns>
    public int AddEnums(params GLenumerant[] enums) {
        if (enums != null) {
            IEnumerable<GLenumerant> matches = (from enumerant in enums
                                                where !ContainsEnum(enumerant.Name)
                                                select enumerant);
            m_enumerants.AddRange(matches);
            return (matches != null) ? matches.Count() : 0;
        }
        return 0;
    }

    /// <summary>
    /// Remove one or more enumerants from this group.
    /// </summary>
    /// <param name="enums">One or more enumerants to be removed.</param>
    /// <returns>Amount of enumerants that were removed.</returns>
    public int RemoveEnums(params GLenumerant[] enums) {
        if (enums != null) {
            return m_enumerants.RemoveAll(enums.Contains);
        }
        return 0;
    }

    /// <summary>
    /// Update the group's references and it's enumerant's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        foreach (GLenumerant enumerant in m_enumerants) {
            enumerant.UpdateReferences(registry);
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
    public GLgroup Clone(GLregistry registry) {
        GLgroup result = new() {
            Name = Name,
            Type = Type,
            Start = Start,
            End = End,
            Vendor = Vendor
        };

        foreach (GLenumerant enumerant in m_enumerants) {
            result.AddEnums(enumerant.Clone(null));
        }

        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}