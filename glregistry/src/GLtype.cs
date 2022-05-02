namespace glregistry;

public class GLtype : ICloneable {
    GLregistry m_registry;

    [XmlAttribute("name")]
    public string NameAsAttribute { get => Name; set { Name = value; } }
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
    /// Prototype for the type.
    /// </summary>
    [XmlText]
    public string[] Prototype;

    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
    }

    public object Clone() => Clone(null);

    public GLtype Clone(GLregistry registry) {
        GLtype result = new() {
            Name = Name,
            Requires = Requires,
            Prototype = Prototype.Clone() as string[]
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}