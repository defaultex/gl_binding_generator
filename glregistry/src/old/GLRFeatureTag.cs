namespace glregistry;

public class GLRFeatureTag : ICloneable {
    GLRegistry m_registry;
    GLREnumerant m_enumerant;
    GLRCommand m_command;

    /// <summary>
    /// API profile name the tag applies to.
    /// </summary>
    public string Profile;
    /// <summary>
    /// API name the tag applies to.
    /// </summary>
    public string API;
    /// <summary>
    /// A required or removed type.
    /// </summary>
    public string TypeName;
    /// <summary>
    /// A required or removed enumerant.
    /// </summary>
    public string EnumerantName;
    /// <summary>
    /// A required or removed command.
    /// </summary>
    public string CommandName;

    /// <summary>
    /// The registry this tag fetches it's references from.
    /// </summary>
    public GLRegistry Registry { get => m_registry; }
    /// <summary>
    /// An enumerant referenced by the enumerant name.
    /// </summary>
    public GLREnumerant Enumerant { get => m_enumerant; }
    /// <summary>
    /// A command referenced by the command name.
    /// </summary>
    public GLRCommand Command { get => m_command; }
    /// <summary>
    /// Check if this tag corresponds to an enumerant.
    /// </summary>
    public bool IsEnumerant { get => !string.IsNullOrEmpty(EnumerantName); }
    /// <summary>
    /// Check if this tag corresponds to a command.
    /// </summary>
    public bool IsCommand { get => !string.IsNullOrEmpty(CommandName); }

    public GLRFeatureTag() { }

    /// <summary>
    /// Update this tag and it's references to the specified registry.
    /// </summary>
    /// <param name="registry">The registry to fetch references from.</param>
    public void Update(GLRegistry registry) {
        m_registry = registry;
        m_enumerant = registry.Enumerants.Find((x) => x.Name == EnumerantName);
        m_command = registry.Commands.Find((x) => x.Name == CommandName);
    }

    /// <summary>
    /// Clone a parameter and copy references to the clone.
    /// </summary>
    public object Clone() => Clone(null);

    /// <summary>
    /// Clone a parameter and update it's references to a new registry. 
    /// If registry is null then the parameter will copy references to the clone.
    /// </summary>
    /// <param name="registry">The new registry to fetch references from.</param>
    public GLRFeatureTag Clone(GLRegistry registry) {
        GLRFeatureTag result = new GLRFeatureTag() {
            Profile = !string.IsNullOrEmpty(Profile) ? Profile.Clone() as string : Profile,
            API = !string.IsNullOrEmpty(API) ? API.Clone() as string : API,
            TypeName = !string.IsNullOrEmpty(TypeName) ? TypeName.Clone() as string : TypeName,
            EnumerantName = !string.IsNullOrEmpty(EnumerantName) ? EnumerantName.Clone() as string : EnumerantName,
            CommandName = !string.IsNullOrEmpty(CommandName) ? CommandName.Clone() as string : CommandName
        };

        if (registry != null) {
            Update(registry);
        } else {
            result.m_registry = m_registry;
            result.m_enumerant = m_enumerant;
            result.m_command = m_command;
        }

        return result;
    }
}