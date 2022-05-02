namespace glregistry;

[XmlRoot("registry")]
public class GLregistry {
    List<GLenumerant> m_enumerants;
    List<string> m_classes;

    [XmlElement("comment")]
    public string Comment;

    [XmlArray("types"), XmlArrayItem("type", Type = typeof(GLtype))]
    public List<GLtype> Types { get; protected set; }

    [XmlElement("enums")]
    public List<GLgroup> Groups { get; protected set; }

    [XmlArray("commands"), XmlArrayItem("command", Type = typeof(GLcommand))]
    public List<GLcommand> Commands { get; protected set; }

    [XmlElement("feature")]
    public List<GLfeature> Features { get; protected set; }

    [XmlArray("extensions"), XmlArrayItem("extension", Type = typeof(GLextension))]
    public List<GLextension> Extensions { get; protected set; }

    [XmlIgnore]
    public List<GLenumerant> Enumerants { get => m_enumerants; }

    [XmlIgnore]
    public List<string> Classes { get => m_classes; }

    public GLregistry() {
        m_enumerants = new();
        m_classes = new();
        Types = new();
        Groups = new();
        Commands = new();
        Features = new();
        Extensions = new();
    }

    public void Initialize() {
        Types.RemoveAll((x) => string.IsNullOrEmpty(x.Name));

        for (int i = 0; i < Classes.Count; i++) {
            Classes[i] = Classes[i].Replace(" ", null).Trim();
        }

        m_enumerants.Clear();
        foreach (GLgroup group in Groups) {
            foreach (GLenumerant enumerant in group.Enumerants) {
                GLenumerant newEnum = m_enumerants.Find((x) => x.Name == enumerant.Name);
                if (newEnum == null) {
                    newEnum = enumerant.Clone(null);
                    m_enumerants.Add(newEnum);
                }
                newEnum.AddGroups(enumerant.Groups.ToArray());
            }
        }

        foreach (GLenumerant enumerant in m_enumerants) {
            foreach (string groupName in enumerant.Groups) {
                GLgroup newGroup = Groups.Find((x) => x.Name == groupName);
                if (newGroup == null) {
                    newGroup = new() {
                        Name = groupName,
                        Type = groupName.EndsWith("Mask") ? "GLbitfield" : "GLenum"
                    };
                    Groups.Add(newGroup);
                }
                newGroup.AddEnums(enumerant);
            }
        }

        foreach (GLcommand command in Commands) {
            if (!string.IsNullOrEmpty(command.Prototype.Class)) {
                command.Prototype.Class = "GL" + command.Prototype.Class.Replace(" ", null);
            }
            foreach (GLprototype param in command.Parameters) {
                if (!string.IsNullOrEmpty(param.Class)) {
                    param.Class = "GL" + param.Class.Replace(" ", null);
                    if (!m_classes.Contains(param.Class)) {
                        m_classes.Add(param.Class);
                    }
                }
            }
        }
    }

    public void UpdateReferences() {
        foreach (GLtype type in Types) {
            type.UpdateReferences(this);
        }
        foreach (GLgroup group in Groups) {
            group.UpdateReferences(this);
        }
        foreach (GLcommand command in Commands) {
            command.UpdateReferences(this);
        }
        foreach (GLfeature feature in Features) {
            feature.UpdateReferences(this);
        }
        foreach (GLextension extension in Extensions) {
            extension.UpdateReferences(this);
        }
    }
}