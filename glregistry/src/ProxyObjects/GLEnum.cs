namespace glregistry;

public class GLEnum : GLBase, INamedObject, ICodeProvider {
    string m_cDecl, m_csName, m_csDecl;

    /// <summary>
    /// Name of the enumerant.
    /// </summary>
    [XmlAttribute("name")]
    public string Name { get; init; }

    /// <summary>
    /// Value of the enumerant, a C-style constant.
    /// </summary>
    [XmlAttribute("value")]
    public string Value { get; init; }

    /// <summary>
    /// An API that specializes the enumerant so that different APIs may have different values for the same enumerant.
    /// </summary>
    [XmlAttribute("api")]
    public GLAPI API { get; init; }

    /// <summary>
    /// C-specific type for the enumerant.
    /// </summary>
    [XmlAttribute("type")]
    public string Type { get; init; }

    /// <summary>
    /// One or more group names the enumerant is found in.
    /// </summary>
    [XmlAttribute("group")]
    public string Groups { get; init; }

    [XmlIgnore]
    public string CSName { get => m_csName; }

    [XmlIgnore]
    public string CDecl { get => m_cDecl; }

    [XmlIgnore]
    public string CSDecl { get => m_csDecl; }

    [XmlIgnore]
    public string SourceFeature { get; set; }

    public void UpdateCode() { 
        m_cDecl = string.Format("#define {0} {1}", Name, Value);
        m_csName = string.Empty;

        // process the spec's naming to produce a reasonable C# equivalent
        string[] nameWords = Name.Split('_');
        for (int i = 1; i < nameWords.Length; i++) {
            if (i == nameWords.Length - 1 && Resources.SkipWords.Contains(nameWords[i])) {
                // skip over words like BIT and BITS
                continue;
            }

            if (Resources.DimensionSpec.Contains(nameWords[i])) {
                // don't adjust dimension spec, just reads badly
                m_csName += nameWords[i];
            } else {
                
                // caps to camel hump conversion
                m_csName += string.Format("{0}{1}", nameWords[i][0], nameWords[i].Substring(1).ToLower());
            }
        }

        if (!string.IsNullOrEmpty(m_csName)) {
            // the value name starts with a number, just prefix it with an underscore
            if (Resources.Base10Digits.Contains(m_csName[0])) {
                m_csName = "_" + m_csName;
            }
        } else {
            // couldn't process the name so just use it as is
            m_csName = Name;
        }

        string type = "GLenum";
        if (Name.EndsWith("_BIT") || Name.EndsWith("_BITS")) {
            type = "GLbitfield";
        } else if (Name == "GL_TIMEOUT_IGNORED") {
            type = "GLuint64";
        }
        m_csDecl = string.Format(Resources.ConstantsDefinition, Name, Value, type);
    }

    public override string ToString() => Name;
}