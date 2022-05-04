namespace glregistry;

/// <summary>
/// Handles storing a reference to an existing object.
/// </summary>
/// <typeparam name="T">Type of object to store a reference for.</typeparam>
public class GLreference<T> : ICloneable {
    internal GLregistry m_registry;

    /// <summary>
    /// Name of the object being referenced.
    /// </summary>
    [XmlAttribute("name")]
    public string Name;

    /// <summary>
    /// Reference being stored.
    /// </summary>
    [XmlIgnore]
    public T Reference;

    object ICloneable.Clone() => Clone();

    /// <summary>
    /// Clone the reference without the existing value.
    /// </summary>
    public GLreference<T> Clone() => new GLreference<T>() { Name = Name };
}
