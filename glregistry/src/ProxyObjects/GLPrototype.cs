namespace glregistry;

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

    [XmlIgnore]
    public string Pointers { get => m_pointers; }

    [XmlIgnore]
    public string CType { get => m_ctype; }

    [XmlIgnore]
    public string CSType { get => m_cstype; }

    [XmlIgnore]
    public string CDecl { get => m_cdecl; }

    [XmlIgnore]
    public string CSDecl { get => m_csdecl; }

    public void UpdateCode() {
        // find the pointers by stripping out the likely 'const' and whitespace
        m_pointers = (Text != null) ? string.Join(' ', Text).Replace(" ", null).Replace("const", null) : string.Empty;

        string type = Type;

        // C-type is simple, type name followed by pointers
        m_ctype = string.Format(Resources.FormatType, type, m_pointers);
        m_cdecl = string.Format("{0} {1}", m_ctype, Name);

        // C#-type is a bit more complex
        if (!string.IsNullOrEmpty(Group) && !Resources.IsPrototypeGroupBlacklisted(Group)) {
            type = Group;
        }
        if (!string.IsNullOrEmpty(Class)) {
            type = "GL" + Class;
        }
        m_cstype = string.Format(Resources.FormatType, type, m_pointers);
        m_csdecl = string.Format("{0} {1}", m_cstype, Name);
    }

    public override string ToString() => Name;
}