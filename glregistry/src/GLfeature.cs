namespace glregistry;

/// <summary>
/// Represents an feature and all of it's dependencies.
/// </summary>
public class GLfeature : INamedObject, IReferenceHolder, ICloneable {
    GLregistry m_registry;

    /// <summary>
    /// API required to support the feature.
    /// </summary>
    [XmlAttribute("api")]
    public string API;

    /// <summary>
    /// Name of the feature.
    /// </summary>
    [XmlAttribute("name")]
    public string Name { get; init; }

    /// <summary>
    /// Version number of the feature.
    /// </summary>
    [XmlAttribute("number")]
    public float Number;

    /// <summary>
    /// A list of dependencies that are required by the extension.
    /// </summary>
    [XmlElement("require")]
    public List<GLdepends> Require { get; init; } = new();

    /// <summary>
    /// A list of dependencies that are removed by the extension.
    /// </summary>
    [XmlElement("remove")]
    public List<GLdepends> Remove { get; init; } = new();

    /// <summary>
    /// Registry the prototype fetches it's references from.
    /// </summary>
    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }

    /// <summary>
    /// Update the feature's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        Require.UpdateReferences(registry);
        Remove.UpdateReferences(registry);
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the feature with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to clone the enumerant into or null for keep references.</param>
    public GLfeature Clone(GLregistry registry = null) {
        GLfeature result = new() {
            API = API,
            Name = Name,
            Number = Number,
            Require = Require.Clone(),
            Remove = Remove.Clone()
        };
        UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}