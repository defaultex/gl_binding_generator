namespace glregistry;

public class GLRCommandParam : ICloneable {
    GLRegistry m_registry;
    GLRGroup m_enumGroup;
    string m_argTypeC, m_argTypeCSharp;

    /// <summary>
    /// Name of the group the command returns.
    /// </summary>
    public string Group;
    /// <summary>
    /// Type of value expected by the parameter.
    /// </summary>
    public string Type;
    /// <summary>
    /// Name of the parameter.
    /// </summary>
    public string Name;
    /// <summary>
    /// C-function prototype of the command parameter.
    /// </summary>
    public string Prototype;
    /// <summary>
    /// Type of object handle expected by the command for this parameter.
    /// </summary>
    public string Class;
    /// <summary>
    /// Length of a parameter with either a constant value or a poorly defined syntax for calculating the length.
    /// </summary>
    public string Length;

    /// <summary>
    /// The registry this command fetches it's references from.
    /// </summary>
    public GLRegistry Registry { get => m_registry; }
    /// <summary>
    /// A group referenced by the parameter, null if no group was referenced.
    /// </summary>
    public GLRGroup EnumGroup { get => m_enumGroup; }
    /// <summary>
    /// A representation of the parameter in C-syntax.
    /// </summary>
    public string ArgTypeC { get => m_argTypeC; }
    /// <summary>
    /// A representation of the parameter in C#-syntax.
    /// </summary>
    public string ArgTypeCSharp { get => m_argTypeCSharp; }

    public GLRCommandParam() {
        m_argTypeCSharp = "";
        m_argTypeC = "";
    }

    /// <summary>
    /// Update the parameter, it's references, and generate additional data.
    /// </summary>
    /// <param name="registry">The registry to fetch references from.</param>
    public void Update(GLRegistry registry) {
        int index = Prototype.LastIndexOf(Name);
        m_argTypeCSharp = (index > 0) ? Prototype.Remove(index) : Prototype;
        m_argTypeC = string.Format("{0} {1}", m_argTypeCSharp.Replace(" *", "*"), Name);
        m_enumGroup = null;

        // determine whether the parameter is an object type or group type
        if (!string.IsNullOrEmpty(Class)) {
            // remove whitespace from the object name to match other type syntax
            string objName = string.Format(References.ObjectName, Class.Replace(" ", null));
            m_argTypeCSharp = m_argTypeCSharp.Replace(Type, objName);
        } else if (!string.IsNullOrEmpty(Group)) {
            // attempt to find the enum group the value belongs to
            m_enumGroup = (from regGroup in registry.Groups
                           where regGroup.Name == Group && regGroup.Name != "Boolean"
                           select regGroup).FirstOrDefault();
            if (m_enumGroup != null) {
                m_argTypeCSharp = Group;
            }
        }

        // replace references to the Boolean group with the boolean type, append pointers and perform conversion
        m_argTypeCSharp = Generator.ConvertType(m_argTypeCSharp);
    }

    public static void ParseCommandParam(GLRCommand command, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string prototype = nav.Value;
            string group = GLRegistry.ParseString(nav.Select("./@group"));
            string cls = GLRegistry.ParseString(nav.Select("./@class"));
            string name = GLRegistry.ParseString(nav.Select("./name"));
            string type = GLRegistry.ParseString(nav.Select("./ptype"));
            string length = GLRegistry.ParseString(nav.Select("./len"));
            GLRCommandParam param = (from commandParam in command.Params
                                     where commandParam.Name == name
                                     select commandParam).FirstOrDefault();
            if (string.IsNullOrEmpty(name) || param != null) {
                continue;
            }
            if (string.IsNullOrEmpty(type)) {
                type = prototype.Replace(name, null);
            }
            param = new() {
                Name = (name != null) ? name.Trim() : name,
                Group = (group != null) ? group.Trim() : group,
                Type = (type != null) ? type.Trim() : type,
                Prototype = (prototype != null) ? prototype.Trim() : prototype,
                Class = (cls != null) ? cls.Trim() : cls,
                Length = (length != null) ? length.Trim() : length
            };
            command.AddParams(param);
        }
    }

    /// <summary>
    /// Clone a parameter and copy references to the clone.
    /// </summary>
    public object Clone() => Clone(null);

    /// <summary>
    /// Clone a parameter and update it's references to a new registry. 
    /// If registry is null then the parameter will copy references to the clone.
    /// </summary>
    /// <param name="registry">The new registry to fetch references from.</param>
    public GLRCommandParam Clone(GLRegistry registry) {
        GLRCommandParam result = new GLRCommandParam() {
            Group = !string.IsNullOrEmpty(Group) ? Group.Clone() as string : Group,
            Type = !string.IsNullOrEmpty(Type) ? Type.Clone() as string : Type,
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Prototype = !string.IsNullOrEmpty(Prototype) ? Prototype.Clone() as string : Prototype,
            Class = !string.IsNullOrEmpty(Class) ? Class.Clone() as string : Class
        };

        if (registry != null) {
            Update(registry);
        } else {
            result.m_registry = m_registry;
            result.m_enumGroup = m_enumGroup;
            result.m_argTypeCSharp = m_argTypeCSharp;
            result.m_argTypeC = m_argTypeC;
        }

        return result;
    }

    public override string ToString() => Name;
}