namespace glregistry;

/// <summary>
/// Represents dependency for types, enumerants and commands within a feature or extension.
/// </summary>
public class GLDepends {
    /// <summary>
    /// Profiles that the dependency is enabled for.
    /// </summary>
    [XmlAttribute("profile")]
    public GLProfile Profile { get; init; }

    /// <summary>
    /// API the dependency belongs to.
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