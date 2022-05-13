namespace glregistry;

[XmlRoot("registry")]
public class GLRegistry {

    [XmlArray("types"), XmlArrayItem("type", Type = typeof(GLType))]
    public List<GLType> Types { get; init; } = new();

    [XmlElement("enums", Type = typeof(GLGroup))]
    public List<GLGroup> Groups { get; init; } = new();

    [XmlArray("commands"), XmlArrayItem("command", Type = typeof(GLCommand))]
    public List<GLCommand> Commands { get; init; } = new();

    [XmlElement("feature", Type = typeof(GLFeature))]
    public List<GLFeature> Features { get; init; } = new();

    [XmlArray("extensions"), XmlArrayItem("extension", Type = typeof(GLExtension))]
    public List<GLExtension> Extensions { get; init; } = new();

    [XmlIgnore]
    public List<GLEnum> Enums { get; init; } = new();

    public void Initialize() {
        Enums.Clear();
        foreach (GLGroup group in Groups) {
            foreach (GLEnum enumerant in group.Enums) {
                if (!Enums.Contains(enumerant.Name)) {
                    Enums.Add(enumerant);
                }
            }
        }
    }
}