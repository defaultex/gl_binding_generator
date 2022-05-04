namespace glregistry;

/// <summary>
/// Represents an OpenGL data type.
/// </summary>
public class GLtype : ICloneable {
    GLregistry m_registry;

    /// <summary>
    /// Name of the type. (Here to support reading from an xml attribute).
    /// </summary>
    [XmlAttribute("name")]
    public string NameAsAttribute { get => Name; set { Name = value; } }

    /// <summary>
    /// Name of the type. (Here to support reading from an xml element).
    /// </summary>
    [XmlElement("name")]
    public string NameAsElement { get => Name; set { Name = value; } }

    /// <summary>
    /// Name of the type.
    /// </summary>
    [XmlIgnore]
    public string Name;

    /// <summary>
    /// Data type required for this type to be supported.
    /// </summary>
    [XmlAttribute("requires")]
    public string Requires;

    /// <summary>
    /// Definition for the type, which may include a prototype.
    /// </summary>
    [XmlText]
    public string[] Definition;

    /// <summary>
    /// Update the type's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the type with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to clone the enumerant into or null for keep references.</param>
    public GLtype Clone(GLregistry registry = null) {
        GLtype result = new() {
            Name = Name,
            Requires = Requires,
            Definition = Definition.Clone() as string[]
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}