namespace glregistry;

/// <summary>
/// Represents a group of enumerants with a definitive name.
/// </summary>
public class GLGroup : GLBase, INamedObject, ICodeProvider {
    string m_cDecl, m_csDecl;

    /// <summary>
    /// Namespace this group is defined for.
    /// </summary>
    [XmlAttribute("namespace")]
    public string Namespace { get; init; }

    /// <summary>
    /// Name of the group.
    /// </summary>
    [XmlAttribute("group")]
    public string Name { get; init; }

    /// <summary>
    /// Data type of the values of enumerants in this group.
    /// </summary>
    [XmlAttribute("type")]
    public string Type { get; init; }

    /// <summary>
    /// Start of the value range to reserve.
    /// </summary>
    [XmlAttribute("start")]
    public string Start { get; init; }

    /// <summary>
    /// End of the value range to reserve.
    /// </summary>
    [XmlAttribute("end")]
    public string End { get; init; }

    /// <summary>
    /// A vendor or purpose for the reserved range in start and end.
    /// </summary>
    [XmlAttribute("vendor")]
    public string Vendor { get; init; }

    /// <summary>
    /// A list of enumerants defined by this group.
    /// </summary>
    [XmlElement("enum", Type = typeof(GLEnum))]
    public List<GLEnum> Enums { get; init; } = new();

    /// <summary>
    /// A string containing the full declaration in C.
    /// </summary>
    [XmlIgnore]
    public string CDecl { get => m_cDecl; }

    /// <summary>
    /// A string containing the full declaration in C#.
    /// </summary>
    [XmlIgnore]
    public string CSDecl { get => m_csDecl; }

    /// <summary>
    /// A kludge to inject the correct API name for use as a header guard.
    /// </summary>
    [XmlIgnore]
    public GLAPI API { get; init; }

    public void UpdateCode() {
        if (string.IsNullOrEmpty(Name)) {
            return;
        }
        Enums.UpdateCode();

        m_cDecl = string.Empty;
        m_csDecl = string.Empty;

        if (Name.EndsWith("Mask")) {
            m_csDecl = string.Format("[Flags]\npublic enum {0} : GLbitfield {{\n", Name);
        } else {
            m_csDecl = string.Format("public enum {0} : GLenum {{\n", Name);
        }

        string apiName = API.ToString().ToLower();
        for (int i = 0; i < Enums.Count; i++) {
            GLEnum enumerants = Enums[i];
            m_cDecl += string.Format("{0} \n", enumerants.CDecl);

            if (!string.IsNullOrEmpty(enumerants.SourceName)) {
                m_csDecl += string.Format("\n#if {3}\n    {0} = {1}.Constants.{2},\n#endif\n\n", enumerants.CSName, apiName, enumerants.Name, enumerants.SourceName);
            } else {
                m_csDecl += string.Format("    {0} = {1}.Constants.{2},\n", enumerants.CSName, apiName, enumerants.Name);
            }
        }
        m_csDecl += "}";
        m_csDecl = m_csDecl.Replace("\n\n", "\n"); // kludge to clean up double spaces
    }

    public override string ToString() => Name;
}