namespace glregistry;

/// <summary>
/// Represents an extension and all of it's dependencies.
/// </summary>
public class GLextension : ICloneable {
    GLregistry m_registry;
    string m_ext;
    List<string> m_supported = new();

    /// <summary>
    /// A pipe separated list of APIs by the extension.
    /// </summary>
    [XmlAttribute("supported")]
    public string Supported {
        get => string.Join('|', m_supported);
        set {
            m_supported.Clear();
            if (!string.IsNullOrEmpty(value)) {
                if (value.IndexOf('|') >= 0) {
                    m_supported.AddRange(value.Split('|'));
                } else {
                    m_supported.Add(value);
                }
            }
        }
    }

    /// <summary>
    /// Name of the extension.
    /// </summary>
    [XmlAttribute("name")]
    public string Name;

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
    /// A list of APIs supported by the extension.
    /// </summary>
    [XmlIgnore]
    public IReadOnlyList<string> SupportedAPIs { get => m_supported; }

    /// <summary>
    /// Abbreviation for the extension.
    /// </summary>
    [XmlIgnore]
    public string Ext { get => m_ext; }

    /// <summary>
    /// Update the extension's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        // extract the extension abbreviation from the name
        if (Name != null && Name.Length > 3) {
            m_ext = Name.Substring(3, Name.IndexOf('_', 3) - 3);
        }

        m_registry = registry;
        Require.UpdateReferences(registry);
        Remove.UpdateReferences(registry);
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the extension with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to clone the enumerant into or null for keep references.</param>
    public GLextension Clone(GLregistry registry = null) {
        GLextension result = new() {
            Supported = Supported,
            Name = Name,
            Require = Require.Clone(),
            Remove = Remove.Clone()
        };
        UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}