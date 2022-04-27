public class GLRCommandParam : ICloneable {
    public string Group;
    public string Type;
    public string Name;
    public string Prototype;
    public string Class;

    public GLRCommandParam() { 
        
    }

    internal static void ParseCommandParam(GLRCommand command, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string prototype = nav.Value;
            string group = GLRegistry.ParseString(nav.Select("./@group"));
            string cls = GLRegistry.ParseString(nav.Select("./@class"));
            string name = GLRegistry.ParseString(nav.Select("./name"));
            string type = GLRegistry.ParseString(nav.Select("./ptype"));
            if (string.IsNullOrEmpty(name) || command.Params.Exists((x) => x.Name.Equals(name))) {
                continue;
            }
            if (string.IsNullOrEmpty(type)) {
                type = prototype.Replace(name, null);
            }
            GLRCommandParam param = new() {
                Name = (name != null) ? name.Trim() : name,
                Group = (group != null) ? group.Trim() : group,
                Type = (type != null) ? type.Trim() : type,
                Prototype = (prototype != null) ? prototype.Trim() : prototype,
                Class = (cls != null) ? cls.Trim() : cls
            };
            command.Params.Add(param);
        }
        command.Params.TrimExcess();
    }

    public object Clone() => new GLRCommandParam() {
        Group = !string.IsNullOrEmpty(Group) ? Group.Clone() as string : Group,
        Type = !string.IsNullOrEmpty(Type) ? Type.Clone() as string : Type,
        Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
        Prototype = !string.IsNullOrEmpty(Prototype) ? Prototype.Clone() as string : Prototype,
        Class = !string.IsNullOrEmpty(Class) ? Class.Clone() as string : Class
    };

    public override string ToString() => Name;
}