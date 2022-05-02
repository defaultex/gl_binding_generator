namespace glregistry;

public class GLcommand : ICloneable {
    GLregistry m_registry;

    [XmlElement("proto")]
    public GLprototype Prototype = new();

    [XmlElement("alias")]
    public GLcommandalias Alias = new();

    [XmlElement("param")]
    public List<GLprototype> Parameters = new();

    [XmlIgnore]
    public string Name { get => Prototype.Name; set => Prototype.Name = value; }

    [XmlIgnore]
    public GLcommand Aliased { get => Alias.CommandRef; }

    [XmlIgnore]
    public string CDecl {
        get {
            const string Format = "{1} {0}({2});";
            string parameters = "";
            for (int i = 0; i < Parameters.Count; i++) {
                if (i < Parameters.Count - 1) {
                    parameters += string.Format("{0}, ", Parameters[i].CDecl);
                } else {
                    parameters += Parameters[i].CDecl;
                }
            }
            return string.Format(Format, Prototype.Name, Prototype.CType, parameters);
        }
    }

    [XmlIgnore]
    public string CSDecl {
        get {
            const string Format = "unsafe delegate* unmanaged[Cdecl]<{2}{1}> {0};";
            string parameters = "";
            foreach (GLprototype param in Parameters) {
                parameters += string.Format("{0}, ", param.CSType);
            }
            return string.Format(Format, Prototype.Name, Prototype.CSType, parameters);
        }
    }

    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        Prototype.UpdateReferences(registry);
        Alias.UpdateReferences(registry);
        foreach (GLprototype param in Parameters) {
            param.UpdateReferences(registry);
        }
    }

    public object Clone() => Clone(null);

    public GLcommand Clone(GLregistry registry) {
        GLcommand result = new() {
            Prototype = Prototype.Clone(null),
            Alias = Alias.Clone(null)
        };
        result.Parameters.AddRange(Parameters);
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => CDecl;
}