namespace glregistry;

public class GLreference<T> : ICloneable {
    [XmlAttribute("name")]
    public string Name;
    [XmlIgnore]
    public T Reference;

    public object Clone() => new GLreference<T>() { Name = Name };
}

public class GLdepends : ICloneable {
    GLregistry m_registry;

    [XmlAttribute("profile")]
    public string Profile;

    [XmlAttribute("api")]
    public string API;

    [XmlElement("type")]
    public List<GLreference<GLtype>> Types = new();

    [XmlElement("enum")]
    public List<GLreference<GLenumerant>> Enumerants = new();

    [XmlElement("command")]
    public List<GLreference<GLcommand>> Commands = new();

    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }

    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        if (registry != null) {
            foreach (GLreference<GLtype> typeRef in Types) {
                typeRef.Reference = registry.Types.Find((x) => x.Name == typeRef.Name);
            }
            foreach (GLreference<GLenumerant> enumRef in Enumerants) {
                enumRef.Reference = registry.Enumerants.Find((x) => x.Name == enumRef.Name);
            }
            foreach (GLreference<GLcommand> commandRef in Commands) {
                commandRef.Reference = registry.Commands.Find((x) => x.Name == commandRef.Name);
            }
        } else {
            foreach (GLreference<GLtype> typeRef in Types) {
                typeRef.Reference = null;
            }
            foreach (GLreference<GLenumerant> enumRef in Enumerants) {
                enumRef.Reference = null;
            }
            foreach (GLreference<GLcommand> commandRef in Commands) {
                commandRef.Reference = null;
            }
        }
    }

    public object Clone() => Clone(null);

    public GLdepends Clone(GLregistry registry) {
        GLdepends result = new() {
            Profile = Profile,
            API = API
        };
        foreach (GLreference<GLtype> typeRef in Types) {
            result.Types.Add(typeRef.Clone() as GLreference<GLtype>);
        }
        foreach (GLreference<GLenumerant> enumRef in Enumerants) {
            result.Enumerants.Add(enumRef.Clone() as GLreference<GLenumerant>);
        }
        foreach (GLreference<GLcommand> commandRef in Commands) {
            result.Commands.Add(commandRef.Clone() as GLreference<GLcommand>);
        }
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }
}