namespace glregistry;

/// <summary>
/// Represents a group of enumerants with a definitive name.
/// </summary>
public class GLgroup : ICloneable {
    GLregistry m_registry;

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
    public List<GLenumerant> Enumerants { get; init; } = new();

    /// <summary>
    /// Add one or more enumerants to the group, ignores duplicates.
    /// </summary>
    /// <param name="enumerants">One or more enumerants to be added.</param>
    /// <returns>Amount of enumerants that were added.</returns>
    public int AddEnums(params GLenumerant[] enumerants) {
        int addCount = 0;
        if (enumerants != null) {
            int enumsCount = enumerants.Length;
            for (int i = 0; i < enumsCount; i++) {
                if (!Enumerants.Contains(enumerants[i])) {
                    Enumerants.Add(enumerants[i]);
                    addCount++;
                }
            }
        }
        return addCount;
    }

    /// <summary>
    /// Remove one or more enumerants from the group.
    /// </summary>
    /// <param name="enumerants">One or more enumerants to be removed.</param>
    /// <returns>Amount of enumerants that were removed.</returns>
    public int RemoveEnums(params GLenumerant[] enumerants) {
        int removeCount = 0;
        if (enumerants != null) {
            int enumsCount = enumerants.Length;
            for (int i = 0; i < enumsCount; i++) {
                if (Enumerants.Remove(enumerants[i])) {
                    removeCount++;
                }
            }
        }
        return removeCount;
    }

    /// <summary>
    /// Update the group's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        Enumerants.UpdateReferences(registry);
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the group with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to clone the enumerant into or null for keep references.</param>
    public GLgroup Clone(GLregistry registry = null) {
        GLgroup result = new() {
            Name = Name,
            Type = Type,
            Start = Start,
            End = End,
            Vendor = Vendor,
            Enumerants = Enumerants.Clone()
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}