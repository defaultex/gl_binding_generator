namespace glregistry;

[XmlRoot("registry")]
public class GLregistry {
    [XmlElement("comment")]
    public string Comment;

    [XmlArray("types"), XmlArrayItem("type", Type = typeof(GLtype))]
    public List<GLtype> Types { get; init; }

    [XmlElement("enums")]
    public List<GLgroup> Groups = new();

    [XmlArray("commands"), XmlArrayItem("command", Type = typeof(GLcommand))]
    public List<GLcommand> Commands = new();

    [XmlElement("feature")]
    public List<GLfeature> Features = new();

    [XmlArray("extensions"), XmlArrayItem("extension", Type = typeof(GLextension))]
    public List<GLextension> Extensions = new();

    [XmlIgnore]
    public List<string> Classes { get; init; } = new();

    [XmlIgnore]
    public List<GLenumerant> Enumerants { get; init; } = new();

    [XmlIgnore]
    public List<GLgroup> ExtraGroups { get; init; } = new();

    public void Initialize() {
        // remove all whitespace from the class names
        for (int i = 0; i < Classes.Count; i++) {
            Classes[i] = Classes[i].Replace(" ", null).Trim();
        }

        // build a master list of enumerants
        foreach (GLgroup group in Groups) {
            if (group.Enumerants == null) {
                continue;
            }
            foreach (GLenumerant enumerant in group.Enumerants) {
                GLenumerant newEnum = Enumerants.Find(enumerant.Name);
                if (newEnum == null) {
                    newEnum = enumerant.Clone(null);
                    Enumerants.Add(newEnum);
                }
                if (enumerant.Groups != null)
                    newEnum.AddGroups(enumerant.Groups.ToArray());
            }
        }

        // extrapolate groups that are implied
        ExtraGroups.Clear();
        foreach (GLenumerant enumerant in Enumerants) {
            if (enumerant.Group == null) {
                continue;
            }
            foreach (string groupName in enumerant.Groups) {
                GLgroup newGroup = Groups.Find(groupName);
                if (newGroup == null) {
                    newGroup = new() {
                        Name = groupName,
                        Type = groupName.EndsWith("Mask") ? "GLbitfield" : "GLenum"
                    };
                    ExtraGroups.Add(newGroup);
                    Groups.Add(newGroup);
                }
                newGroup.AddEnums(enumerant);
            }
        }
        
        foreach (GLcommand command in Commands) {
            if (!string.IsNullOrEmpty(command.Prototype.Class)) {
                command.Prototype.Class = command.Prototype.Class.Replace(" ", null);
            }
            foreach (GLprototype param in command.Parameters) {
                if (!string.IsNullOrEmpty(param.Class)) {
                    param.Class = param.Class.Replace(" ", null);
                    if (!Classes.Contains(param.Class)) {
                        Classes.Add(param.Class);
                    }
                }
            }
        }
    }

    public void UpdateReferences() {
        Types.UpdateReferences(this);
        Enumerants.UpdateReferences(this);
        Groups.UpdateReferences(this);
        Commands.UpdateReferences(this);
        Features.UpdateReferences(this);
        Extensions.UpdateReferences(this);
    }

    public void UpdateCode() {
        Enumerants.UpdateCode();
        Groups.UpdateCode();
        Commands.UpdateCode();
    }
}