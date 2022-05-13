namespace glregistry;

public class GLType : GLBase, INamedObject {
    /// <summary>
    /// Name of the type. (Here to support reading from an xml attribute).
    /// </summary>
    [XmlAttribute("name")]
    public string NameAsAttribute { get => Name; set => Name = value; }

    /// <summary>
    /// Name of the type. (Here to support reading from an xml element).
    /// </summary>
    [XmlElement("name")]
    public string NameAsElement { get => Name; set => Name = value; }

    /// <summary>
    /// Data type required for this type to be supported.
    /// </summary>
    [XmlAttribute("requires")]
    public string Requires { get; init; }

    /// <summary>
    /// Text that wasn't deserialized by other tags.
    /// </summary>
    [XmlText]
    public string[] Text { get; init; }

    /// <summary>
    /// Name of the type.
    /// </summary>
    [XmlIgnore]
    public string Name { get; private set; }

    public override string ToString() => Name;
}