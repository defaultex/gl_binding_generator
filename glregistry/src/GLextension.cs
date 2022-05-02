namespace glregistry;

public class GLextension : ICloneable {
    GLregistry m_registry;
    List<string> m_supported = new();

    [XmlAttribute("supported")]
    public string Supported {
        get => string.Join(',', m_supported);
        set {
            m_supported.Clear();
            if (!string.IsNullOrEmpty(value)) {
                if (value.IndexOf(',') >= 0) {
                    m_supported.AddRange(value.Split(','));
                } else {
                    m_supported.Add(value);
                }
            }
        }
    }

    [XmlAttribute("name")]
    public string Name;

    [XmlElement("require")]
    public List<GLdepends> Require = new();
    
    [XmlElement("remove")]
    public List<GLdepends> Remove = new();

    [XmlIgnore]
    public List<string> SupportedAPIs{ get => m_supported; }
    [XmlIgnore]
    public string Ext { get => Name.Substring(3, Name.IndexOf('_', 3) - 3); }

    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        foreach (GLdepends require in Require) {
            require.UpdateReferences(registry);
        }
        foreach (GLdepends remove in Remove) {
            remove.UpdateReferences(registry);
        }
    }

    public object Clone() => Clone(null);

    public GLfeature Clone(GLregistry registry) {
        GLfeature result = new() {
            API = Supported,
            Name = Name
        };
        foreach(GLdepends dep in Require) {
            result.Require.Add(dep.Clone(null));
        }
        foreach(GLdepends dep in Remove) {
            result.Remove.Add(dep.Clone(null));
        }
        UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}