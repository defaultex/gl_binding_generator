namespace glregistry;

/// <summary>
/// Represents a complete, loaded OpenGL registry with no filtering applied.
/// </summary>
[XmlRoot("registry")]
public class GLRegistry {
    /// <summary>
    /// Types that are defined in the OpenGL registry.
    /// </summary>
    [XmlArray("types"), XmlArrayItem("type", Type = typeof(GLType))]
    public List<GLType> Types { get; init; } = new();

    /// <summary>
    /// Groups that are defined in the OpenGL registry.
    /// </summary>
    [XmlElement("enums", Type = typeof(GLGroup))]
    public List<GLGroup> Groups { get; init; } = new();

    /// <summary>
    /// Commands that are defined in the OpenGL registry.
    /// </summary>
    [XmlArray("commands"), XmlArrayItem("command", Type = typeof(GLCommand))]
    public List<GLCommand> Commands { get; init; } = new();

    /// <summary>
    /// Feature sets defined in the OpenGL registry.
    /// </summary>
    [XmlElement("feature", Type = typeof(GLFeature))]
    public List<GLFeature> Features { get; init; } = new();

    /// <summary>
    /// Feature sets from extensions defined in the OpenGL registry.
    /// </summary>
    [XmlArray("extensions"), XmlArrayItem("extension", Type = typeof(GLExtension))]
    public List<GLExtension> Extensions { get; init; } = new();

    /// <summary>
    /// Individual enumerants extracted from the groups defined in teh OpenGL registry.
    /// </summary>
    [XmlIgnore]
    public List<GLEnum> Enums { get; init; } = new();

    /// <summary>
    /// Initialize the registry for use after it has been deserialized.
    /// </summary>
    public void Initialize() {
        Enums.Clear();
        for (int i = 0; i < Groups.Count; i++) {
            GLGroup group = Groups[i];
            for (int j = 0; j < group.Enums.Count; j++) {
                GLEnum enumerant = group.Enums[j];
                if (!Enums.Contains(enumerant.Name)) {
                    Enums.Add(enumerant);
                }
            }
        }
    }
}