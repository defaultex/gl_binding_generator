namespace glregistry;

/// <summary>
/// Handles storing a reference to an existing object.
/// </summary>
/// <typeparam name="T">Type of object to store a reference for.</typeparam>
public class GLreference<T> : INamedObject, IReferenceHolder, ICloneable where T : class, INamedObject, IReferenceHolder {
    static readonly string TypeName = typeof(T).Name;

    GLregistry m_registry;

    /// <summary>
    /// Name of the object being referenced.
    /// </summary>
    [XmlAttribute("name")]
    public string Name{ get; set; }

    /// <summary>
    /// Reference being stored.
    /// </summary>
    [XmlIgnore]
    public T Reference;

    /// <summary>
    /// Update the references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        if (m_registry != null) {
            switch (TypeName) {
                case nameof(GLtype): Reference = m_registry.Types.Find(Name) as T; break;
                case nameof(GLenumerant): Reference = m_registry.Enumerants.Find(Name) as T; break;
                case nameof(GLgroup): Reference = m_registry.Groups.Find(Name) as T; break;
                case nameof(GLcommand): Reference = m_registry.Commands.Find(Name) as T; break;
            }
        }
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the reference without the existing value.
    /// </summary>
    public GLreference<T> Clone(GLregistry registry = null) {
        GLreference<T> result = new() {
            Name = Name
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }
}
