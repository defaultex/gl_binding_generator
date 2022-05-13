
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
}
