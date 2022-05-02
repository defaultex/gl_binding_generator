namespace glregistry;

public class GLfeature : ICloneable {
    GLregistry m_registry;

    [XmlAttribute("api")]
    public string API;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("number")]
    public float Number;

    [XmlElement("require")]
    public List<GLdepends> Require = new();
    [XmlElement("remove")]
    public List<GLdepends> Remove = new();

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
            API = API,
            Name = Name,
            Number = Number
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