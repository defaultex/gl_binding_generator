public class GLRCommand : ICloneable {
    public string Prototype;
    public string Name;
    public string Group;
    public string Alias;
    public List<GLRCommandParam> Params;

    public GLRCommand() {
        Params = new();
    }

    internal static void ParseCommands(GLRegistry registry, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string alias = GLRegistry.ParseString(nav.Select("./alias/@name"));
            string prototype = GLRegistry.ParseString(nav.Select("./proto"));
            string name = GLRegistry.ParseString(nav.Select("./proto/name"));
            string group = GLRegistry.ParseString(nav.Select("./proto/@group"));
            if (string.IsNullOrEmpty(name) || registry.Commands.Exists((x) => x.Equals(name))) {
                continue;
            }
            GLRCommand command = new() {
                Name = (name != null) ? name.Trim() : name,
                Alias = (alias != null) ? alias.Trim() : alias,
                Prototype = (prototype != null) ? prototype.Trim() : prototype,
                Group = (group != null) ? group.Trim() : group
            };
            registry.Commands.Add(command);
            GLRCommandParam.ParseCommandParam(command, nav.Select("./param"));
        }
        registry.Commands.TrimExcess();
    }

    public object Clone() {
        GLRCommand result = new() {
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Alias = !string.IsNullOrEmpty(Alias) ? Alias.Clone() as string : Alias,
            Prototype = !string.IsNullOrEmpty(Prototype) ? Prototype.Clone() as string : Prototype,
            Group = !string.IsNullOrEmpty(Group) ? Group.Clone() as string : Group
        };
        Params.ForEach((p) => result.Params.Add(p.Clone() as GLRCommandParam));
        result.Params.TrimExcess();
        return result;
    }

    public override string ToString() => Name;
}
