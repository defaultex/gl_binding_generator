namespace glregistry;

public class GLExtension : INamedObject {
    GLAPI m_api = GLAPI.None;

    /// <summary>
    /// Name of the feature.
    /// </summary>
    [XmlAttribute("name")]
    public string Name { get; init; }

    /// <summary>
    /// APIs required to support the feature. In the format of a Regex query.
    /// </summary>
    [XmlAttribute("supported")]
    public string SupportedAPIPattern {
        get {
            string result = "";
            if ((m_api & GLAPI.GL) != GLAPI.None) {
                result += "gl|";
            } else if ((m_api & GLAPI.GLCore) != GLAPI.None) {
                result += "glcore|";
            } else if ((m_api & GLAPI.GLES1) != GLAPI.None) {
                result += "gles1|";
            } else if ((m_api & GLAPI.GLES2) != GLAPI.None) {
                result += "gles2|";
            } else if ((m_api & GLAPI.GLSC2) != GLAPI.None) {
                result += "glsc2|";
            }

            if (result.EndsWith('|')) {
                return result.Substring(0, result.Length - 1);
            } else {
                return result;
            }
        }
        init {
            if (string.IsNullOrEmpty(value)) {
                return;
            }

            string[] values = value.Split('|');
            m_api = GLAPI.None;
            for (int i = 0; i < values.Length; i++) {
                if (values[i] == "gl") {
                    m_api |= GLAPI.GL;
                } else if (values[i] == "glcore") {
                    m_api |= GLAPI.GLCore;
                } else if (values[i] == "gles1") {
                    m_api |= GLAPI.GLES1;
                } else if (values[i] == "gles2") {
                    m_api |= GLAPI.GLES2;
                } else if (values[i] == "glsc2") {
                    m_api |= GLAPI.GLSC2;
                }
            }
        }
    }

    /// <summary>
    /// Flags indicating which APIs the extension is supported by.
    /// </summary>
    [XmlIgnore]
    public GLAPI SupportedAPIs { get => m_api; }

    /// <summary>
    /// A list of dependencies that are required by the feature.
    /// </summary>
    [XmlElement("require")]
    public List<GLDepends> Require { get; init; } = new();

    /// <summary>
    /// A list of dependencies that are removed by the feature.
    /// </summary>
    [XmlElement("remove")]
    public List<GLDepends> Remove { get; init; } = new();

    public override string ToString() => Name;
}