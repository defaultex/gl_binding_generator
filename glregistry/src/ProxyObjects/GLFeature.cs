namespace glregistry;

public class GLFeature : INamedObject {
    /// <summary>
    /// API required to support the feature.
    /// </summary>
    [XmlAttribute("api")]
    public GLAPI API { get; init; }

    /// <summary>
    /// Name of the feature.
    /// </summary>
    [XmlAttribute("name")]
    public string Name { get; init; }

    /// <summary>
    /// Version number of the feature. Format = Major.Minor
    /// </summary>
    [XmlAttribute("number")]
    public float Number { get; init; } = -1;

    /// <summary>
    /// A list of dependencies that are required by the feature.
    /// </summary>
    [XmlElement("require", Type = typeof(GLDepends))]
    public List<GLDepends> Require { get; init; } = new();

    /// <summary>
    /// A list of dependencies that are removed by the feature.
    /// </summary>
    [XmlElement("remove", Type = typeof(GLDepends))]
    public List<GLDepends> Remove { get; init; } = new();

    public override string ToString() => Name;
}