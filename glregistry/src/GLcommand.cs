namespace glregistry;

/// <summary>
/// Represents a command that can be invoked in the OpenGL API.
/// </summary>
public class GLcommand : INamedObject, IReferenceHolder, ICodeProvider, ICloneable {
    GLregistry m_registry;
    string m_cdecl, m_csdecl;

    /// <summary>
    /// A definition for code implementation of the function.
    /// </summary>
    [XmlElement("proto")]
    public GLprototype Prototype = new();

    /// <summary>
    /// Alias to an existing command that defines the command's behavior. 
    /// </summary>
    [XmlElement("alias")]
    public GLreference<GLcommand> Alias = new();

    /// <summary>
    /// An array of parameters in the order they appear in the command's prototype.
    /// </summary>
    [XmlElement("param")]
    public List<GLprototype> Parameters = new();

    /// <summary>
    /// Name of the command.
    /// </summary>
    [XmlIgnore]
    public string Name { get => Prototype.Name; }

    /// <summary>
    /// The command that is aliased by the command.
    /// </summary>
    [XmlIgnore]
    public GLcommand Aliased { get => (Alias != null) ? Alias.Reference : null; }

    /// <summary>
    /// A string containing the full declaration in C.
    /// </summary>
    [XmlIgnore]
    public string CDecl { get => m_cdecl; }

    /// <summary>
    /// A string containing the full declaration in C#.
    /// </summary>
    [XmlIgnore]
    public string CSDecl { get => m_csdecl; }

    /// <summary>
    /// Update the command's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        Prototype.UpdateReferences(registry);
        Parameters.UpdateReferences(registry);
        Alias.UpdateReferences(registry);
    }

    public void UpdateCode() {
        Prototype.UpdateCode();
        Parameters.UpdateCode();

        int paramCount = Parameters.Count;

        // create a new C-declaration to handle parameter lists changes
        m_cdecl = string.Empty;
        for (int i = 0; i < paramCount; i++) {
            if (i < paramCount - 1) {
                // add a comma if this is not the last parameter
                m_cdecl += string.Format(Resources.FormatCommandParam, Parameters[i].CDecl);
            } else {
                m_cdecl += Parameters[i].CDecl;
            }
        }
        m_cdecl = string.Format(Resources.FormatCommandCdecl, Prototype.Name, Prototype.CType, m_cdecl);

        // create a new C#-declaration to handle parameter lists changes
        m_csdecl = string.Empty;
        for (int i = 0; i < paramCount; i++) {
            m_csdecl += string.Format(Resources.FormatCommandParam, Parameters[i].CSType);
        }
        m_csdecl = string.Format(Resources.FormatCommandCSdecl, Prototype.Name, Prototype.CSType, m_csdecl);
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the command with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to keep existing references.</param>
    public GLcommand Clone(GLregistry registry = null) {
        GLcommand result = new() {
            Prototype = Prototype.Clone(null),
            Alias = Alias.Clone() as GLreference<GLcommand>,
            Parameters = Parameters.Clone()
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => CDecl;
}