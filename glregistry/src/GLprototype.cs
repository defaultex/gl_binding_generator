namespace glregistry;

public class GLprototype : ICloneable {
    GLregistry m_registry;
    GLgroup m_group;
    GLtype m_type;

    [XmlAttribute("group")]
    public string Group;

    [XmlAttribute("class")]
    public string Class;

    [XmlElement("ptype")]
    public string Type;

    [XmlElement("name")]
    public string Name;

    [XmlAttribute("len")]
    public string Length;

    [XmlText]
    public string[] Declaration;

    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }

    [XmlIgnore]
    public GLtype TypeRef { get => m_type; }

    [XmlIgnore]
    public GLgroup GroupRef { get => m_group; }

    [XmlIgnore]
    public string Pointers {
        get => (Declaration != null) ? string.Join("", Declaration)
                                              .Replace(" ", null)
                                              .Replace("const", null) : string.Empty;
    }

    [XmlIgnore]
    public string CType { get => string.Format("{0}{1}", Type, Pointers); }
    
    [XmlIgnore]
    public string CSType {
        get {
            string type = Type;
            if (!string.IsNullOrEmpty(Group) && Group != "Boolean" && 
                Group != "handleARB" && Group != "String" && Group != "vdpauSurfaceNV") {
                type = Group;
            }
            if (!string.IsNullOrEmpty(Class)) {
                type = Class;
            }
            return string.Format("{0}{1}", type, Pointers);
        }
    }

    [XmlIgnore]
    public string CDecl { get => CType + " " + Name; }

    [XmlIgnore]
    public string CSDecl { get => CSType + " " + Name; }

    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        if (registry != null) {
            m_type = (from type in registry.Types
                      where type.Name == Type
                      select type).FirstOrDefault();
            m_group = (from enumGroup in registry.Groups
                       where enumGroup.Name == Group
                       select enumGroup).FirstOrDefault();
        } else {
            m_type = null;
            m_group = null;
        }
    }

    public object Clone() => Clone(null);

    public GLprototype Clone(GLregistry registry) {
        GLprototype result = new() {
            Group = Group,
            Class = Class,
            Type = Type,
            Name = Name,
            Declaration = Declaration.Clone() as string[]
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => CSDecl;
}