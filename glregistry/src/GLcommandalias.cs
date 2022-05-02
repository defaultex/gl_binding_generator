namespace glregistry;

public class GLcommandalias : ICloneable {
    GLregistry m_registry;
    GLcommand m_command;

    [XmlAttribute("name")]
    public string Name;

    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }
    [XmlIgnore]
    public GLcommand CommandRef { get => m_command; }

    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        if (registry != null) {
            m_command = (from command in registry.Commands
                         where command.Name == Name
                         select command).FirstOrDefault();
        }
    }

    public object Clone() => Clone(null);

    public GLcommandalias Clone(GLregistry registry) {
        GLcommandalias result = new() {
            Name = Name
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}
