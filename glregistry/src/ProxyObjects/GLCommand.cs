namespace glregistry;

/// <summary>
/// Represents a command that can be invoked in the OpenGL API.
/// </summary>
public class GLCommand : GLBase, INamedObject, ICodeProvider {
    string m_cdecl, m_csdecl;
    
    /// <summary>
    /// Namespace this group is defined for.
    /// </summary>
    [XmlAttribute("namespace")]
    public string Namespace { get; init; }

    /// <summary>
    /// A definition for code implementation of the function.
    /// </summary>
    [XmlElement("proto", Type = typeof(GLPrototype))]
    public GLPrototype Prototype { get; init; } = new();

    /// <summary>
    /// An array of parameters in the order they appear in the command's prototype.
    /// </summary>
    [XmlElement("param", Type = typeof(GLPrototype))]
    public List<GLPrototype> Parameters { get; init; } = new();

    /// <summary>
    /// Alias to an existing command that defines this command's behavior. 
    /// </summary>
    [XmlElement("alias", Type = typeof(GLAlias))]
    public GLAlias Alias { get; init; } = new();

    /// <summary>
    /// GLX protocol information.
    /// </summary>
    [XmlElement("glx", Type = typeof(GLXInfo))]
    public GLXInfo GLXType { get; init; } = new();

    /// <summary>
    /// Specifies another command that is the vectorized form of this command.
    /// </summary>
    [XmlElement("vecequiv", Type = typeof(GLAlias))]
    public GLAlias VecEquiv { get; init; } = new();

    /// <summary>
    /// Name of the command.
    /// </summary>
    [XmlIgnore]
    public string Name { get => Prototype.Name; }

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

    public override string ToString() => Prototype.Name;
}