namespace glregistry;

public class GLAlias {
    /// <summary>
    /// Name of the aliased object.
    /// </summary>
    [XmlAttribute("name")]
    public string Name;

    public override string ToString() => Name;
}
