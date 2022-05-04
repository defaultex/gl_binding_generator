namespace glregistry;

/// <summary>
/// Represents a prototype definition for commands and parameters.
/// </summary>
public class GLprototype : ICloneable {
    GLregistry m_registry;
    GLgroup m_group;
    GLtype m_type;
    string m_pointers, m_ctype, m_cstype, m_cdecl, m_csdecl;

    /// <summary>
    /// Group name that the possible values are defined in.
    /// </summary>
    [XmlAttribute("group")]
    public string Group;

    /// <summary>
    /// OpenGL object type of the value.
    /// </summary>
    [XmlAttribute("class")]
    public string Class;

    /// <summary>
    /// Data type of the values.
    /// </summary>
    [XmlElement("ptype")]
    public string Type;

    /// <summary>
    /// Name of the command/parameter.
    /// </summary>
    [XmlElement("name")]
    public string Name;

    /// <summary>
    /// A vague description of how to derive the length of a pointer's data.
    /// </summary>
    [XmlAttribute("len")]
    public string Length;

    /// <summary>
    /// Raw declaration that couldn't be capture by other tags.
    /// </summary>
    [XmlText]
    public string[] Declaration;

    /// <summary>
    /// Registry the prototype fetches it's references from.
    /// </summary>
    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }

    /// <summary>
    /// Data type referenced by the value.
    /// </summary>
    [XmlIgnore]
    public GLtype TypeRef { get => m_type; }

    /// <summary>
    /// Group referenced by the value
    /// </summary>
    [XmlIgnore]
    public GLgroup GroupRef { get => m_group; }

    /// <summary>
    /// A string containing only the pointer symbols of the declaration.
    /// </summary>
    [XmlIgnore]
    public string Pointers { get => m_pointers; }

    /// <summary>
    /// A string containing the C-language definition of the type.
    /// </summary>
    [XmlIgnore]
    public string CType { get => m_ctype; }

    /// <summary>
    /// A string containing the C#-language definition of the type.
    /// </summary>
    [XmlIgnore]
    public string CSType { get => m_cstype; }

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
    /// Update the prototype's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;

        // find the pointers by stripping out the likely 'const' and whitespace
        m_pointers = (Declaration != null) ? string.Join("", Declaration)
                                                   .Replace(" ", null)
                                                   .Replace("const", null)
                                           : string.Empty;

        // C-type is simple, type name followed by pointers
        m_ctype = string.Format(Resources.FormatType, Type, Pointers);
        m_cdecl = string.Format("{0} {1}", m_ctype, Name);

        // C#-type is a bit more complex
        string type = Type;
        if (!string.IsNullOrEmpty(Group) && !Resources.IsPrototypeGroupBlacklisted(Group)) {
            type = Group;
        }
        if (!string.IsNullOrEmpty(Class)) {
            type = Class;
        }
        m_cstype = string.Format(Resources.FormatType, type, m_pointers);
        m_csdecl = string.Format("{0} {1}", m_cstype, Name);

        if (registry != null) {
            m_type = registry.Types.Find(Type);
            m_group = registry.Groups.Find(Group);
        } else {
            m_type = null;
            m_group = null;
        }
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the prototype with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to keep existing references.</param>
    public GLprototype Clone(GLregistry registry = null) {
        GLprototype result = new() {
            Group = Group,
            Class = Class,
            Type = Type,
            Name = Name,
            Declaration = Declaration.Clone() as string[]
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => CSDecl;
}