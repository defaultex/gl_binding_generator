namespace glregistry;

/// <summary>
/// Represents dependency for types, enumerants and commands within a feature or extension.
/// </summary>
public class GLdepends : ICloneable {
    GLregistry m_registry;

    /// <summary>
    /// Comma-delimited list of APIs the dependency is supported by.
    /// </summary>
    [XmlAttribute("profile")]
    public string Profile;

    /// <summary>
    /// Name of the API the dependency belongs to.
    /// </summary>
    [XmlAttribute("api")]
    public string API;

    /// <summary>
    /// Types that are referenced as a dependency.
    /// </summary>
    [XmlElement("type")]
    public List<GLreference<GLtype>> Types = new();

    /// <summary>
    /// Enumerants that are referenced as dependency.
    /// </summary>
    [XmlElement("enum")]
    public List<GLreference<GLenumerant>> Enumerants = new();

    /// <summary>
    /// Commands that are referenced as a dependency.
    /// </summary>
    [XmlElement("command")]
    public List<GLreference<GLcommand>> Commands = new();

    /// <summary>
    /// Registry the dependency fetches it's references from.
    /// </summary>
    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }

    /// <summary>
    /// Update the dependencies' references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        Types.UpdateReferences(registry);
        Enumerants.UpdateReferences(registry);
        Commands.UpdateReferences(registry);
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the dependency with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to keep existing references.</param>
    public GLdepends Clone(GLregistry registry = null) {
        GLdepends result = new() {
            Profile = Profile,
            API = API,
            Types = Types.Clone(),
            Enumerants = Enumerants.Clone(),
            Commands = Commands.Clone()
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }
}