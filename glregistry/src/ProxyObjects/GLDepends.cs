namespace glregistry;

public class GLDepends {
    /// <summary>
    /// Comma-delimited list of APIs the dependency is supported by.
    /// </summary>
    [XmlAttribute("profile")]
    public GLProfile Profile { get; init; }

    /// <summary>
    /// Name of the API the dependency belongs to.
    /// </summary>
    [XmlAttribute("api")]
    public GLAPI API { get; init; }

    /// <summary>
    /// Types that are referenced as a dependency.
    /// </summary>
    [XmlElement("type", Type = typeof(GLAlias))]
    public List<GLAlias> Types { get; init; } = new();

    /// <summary>
    /// Enumerants that are referenced as dependency.
    /// </summary>
    [XmlElement("enum", Type = typeof(GLAlias))]
    public List<GLAlias> Enumerants { get; init; } = new();

    /// <summary>
    /// Commands that are referenced as a dependency.
    /// </summary>
    [XmlElement("command", Type = typeof(GLAlias))]
    public List<GLAlias> Commands { get; init; } = new();
}