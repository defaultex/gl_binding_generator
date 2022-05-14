namespace glregistry;

/// <summary>
/// Base class for objects that are referenced by features and extensions.
/// </summary>
public class GLBase {
    /// <summary>
    /// Should the feature be defined during generation?
    /// </summary>
    [XmlIgnore]
    public bool Required = false;

    /// <summary>
    /// Has the feature been defined already?
    /// </summary>
    [XmlIgnore]
    public bool Declared = false;

    /// <summary>
    /// Name of the feature or extension where the object is defined.
    /// </summary>
    [XmlIgnore]
    public string SourceName = null;
}
