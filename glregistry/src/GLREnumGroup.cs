public class GLREnumGroup : ICloneable {
    public string Name;
    public string Type;
    public string Vendor;
    public string Start;
    public string End;
    public List<GLREnumValue> Values;

    public GLREnumGroup() {
        Values = new();
    }

    internal static void ParseEnumGroups(GLRegistry registry, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string ns = GLRegistry.ParseString(nav.Select("./@namespace"));
            string group = GLRegistry.ParseString(nav.Select("./@group"));
            string type = GLRegistry.ParseString(nav.Select("./@type"));
            string start = GLRegistry.ParseString(nav.Select("./@start"));
            string end = GLRegistry.ParseString(nav.Select("./@end"));
            string vendor = GLRegistry.ParseString(nav.Select("./@vendor"));

            // map the constant enums into groups
            if (string.IsNullOrEmpty(group)) {
                group = string.Format("Constants", start, end);
            }

            // determine the type of the enum group
            if (string.IsNullOrEmpty(type)) {
                type = (!string.IsNullOrEmpty(group) && group.EndsWith("Mask")) ? "GLbitfield" : "GLenum";
            } else if (type == "bitmask") {
                type = "GLbitfield";
            }

            GLREnumGroup enumGroup = registry.EnumGroups.Find((x) => x.Name.Equals(group));
            if (!registry.EnumGroups.Exists((x) => x.Name.Equals(group))) {
                enumGroup = new() {
                    Name = (group != null) ? group.Trim() : group,
                    Type = (type != null) ? type.Trim() : type,
                    Vendor = (vendor != null) ? vendor.Trim() : vendor,
                    Start = (start != null) ? start.Trim() : start,
                    End = (end != null) ? end.Trim() : end
                };
                registry.EnumGroups.Add(enumGroup);
            }
            GLREnumValue.ParseEnumValue(enumGroup, nav.Select("./enum"));
        }
        registry.EnumGroups.TrimExcess();
    }

    public object Clone() {
        GLREnumGroup result = new() {
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Type = !string.IsNullOrEmpty(Type) ? Type.Clone() as string : Type,
            Vendor = !string.IsNullOrEmpty(Vendor) ? Vendor.Clone() as string : Vendor,
            Start = !string.IsNullOrEmpty(Start) ? Start.Clone() as string : Start,
            End = !string.IsNullOrEmpty(End) ? End.Clone() as string : End
        };
        Values.ForEach((v) => result.Values.Add(v.Clone() as GLREnumValue));
        result.Values.TrimExcess();
        return result;
    }

    public override string ToString() => Name;
}
