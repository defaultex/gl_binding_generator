public class GLREnumValue : ICloneable {
    public string Value;
    public string Name;
    public List<string> Groups;

    public GLREnumValue() {
        Groups = new();
    }

    internal static void ParseEnumValue(GLREnumGroup enumGroup, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string name = GLRegistry.ParseString(nav.Select("./@name"));
            string value = GLRegistry.ParseString(nav.Select("./@value"));
            string groups = GLRegistry.ParseString(nav.Select("./@group"));
            name = (name != null) ? name.Trim() : name;
            value = (value != null) ? value.Trim() : value;
            groups = (groups != null) ? groups.Trim() : groups;

            if (string.IsNullOrEmpty(name) || enumGroup.Values.Exists((x) => x.Name == name)) {
                continue;
            }

            string[] groupArray = !string.IsNullOrEmpty(groups) ?
                (groups.IndexOf(',') >= 0 ? groups.Split(',') : new string[1] { groups }) :
                (new string[0]
            );

            GLREnumValue enumValue = new() {
                Name = name,
                Value = value
            };
            enumValue.Groups.AddRange(groupArray);
            enumValue.Groups.TrimExcess();
            enumGroup.Values.Add(enumValue);
        }
        enumGroup.Values.TrimExcess();
    }

    public object Clone() {
        GLREnumValue result = new() {
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Value = !string.IsNullOrEmpty(Value) ? Value.Clone() as string : Value
        };
        Groups.ForEach((g) => result.Groups.Add(g.Clone() as string));
        result.Groups.TrimExcess();
        return result;
    }

    public override string ToString() => string.Format("{0} = {1}", Name, Value);
}
