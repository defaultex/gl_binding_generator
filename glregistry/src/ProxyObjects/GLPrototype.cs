namespace glregistry;

/// <summary>
/// Represents a prototype definition for commands and parameters.
/// </summary>
public class GLPrototype : INamedObject, ICodeProvider {
    string m_class, m_pointers, m_ctype, m_cdecl, m_cstype, m_csdecl;

    /// <summary>
    /// Group name that the possible values are defined in.
    /// </summary>
    [XmlAttribute("group")]
    public string Group { get; init; } 

    /// <summary>
    /// OpenGL object type of the value.
    /// </summary>
    [XmlAttribute("class")]
    public string Class { get => m_class; init => m_class = value.Replace(" ", null); }

    /// <summary>
    /// Data type of the values.
    /// </summary>
    [XmlElement("ptype")]
    public string Type { get; init; }

    /// <summary>
    /// Name of the command or parameter.
    /// </summary>
    [XmlElement("name")]
    public string Name { get; init; }

    /// <summary>
    /// A vague description of how to derive the length of a pointer's data.
    /// </summary>
    [XmlAttribute("len")]
    public string Length { get; init; }

    /// <summary>
    /// Text that wasn't deserialized by other tags.
    /// </summary>
    [XmlText]
    public string[] Text { get; init; }

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

    public void UpdateCode() {
        // find the pointers by stripping out the likely 'const' and whitespace
        m_pointers = (Text != null) ? string.Join(' ', Text).Replace(" ", null).Replace("const", null) : string.Empty;

        string type = Type;

        // C-type is simple, type name followed by pointers
        m_ctype = string.Format(Resources.FormatPtrType, type, m_pointers);
        m_cdecl = string.Format(Resources.FormatDecl, m_ctype, Name);

        // C#-type is a bit more complex
        if (!string.IsNullOrEmpty(Group) && !Resources.IsPrototypeGroupBlacklisted(Group)) {
            type = Resources.GetGroupName(Group);
        }
        if (!string.IsNullOrEmpty(Class)) {
            type = string.Format(Resources.FormatObjType, Class);
        }
        
        m_cstype = string.Format(Resources.FormatPtrType, type, m_pointers);
        m_csdecl = string.Format(Resources.FormatDecl, m_cstype, Name);
    }

    public override string ToString() => Name;
}