public class GLRFeature : ICloneable {
    public string API;
    public string Name;
    public string Number;
    public List<string> RequiredTypes;
    public List<string> RequireEnums;
    public List<string> RequireCommands;
    public List<string> RemoveEnums;
    public List<string> RemoveCommands;

    public List<GLREnumValue> Enums;
    public List<GLRCommand> Commands;

    public GLRFeature() {
        RequiredTypes = new();
        RequireEnums = new();
        RequireCommands = new();
        RemoveEnums = new();
        RemoveCommands = new();
    }

    internal void Update(GLRegistry registry) {
        Enums = new();
        Commands = new();
        foreach (GLREnumGroup enumGroup in registry.EnumGroups) {
            foreach (GLREnumValue enumValue in enumGroup.Values) {
                if (RequireEnums.Exists(enumValue.Name.Equals) && !Enums.Exists((enumValue.Equals))) {
                    Enums.Add(enumValue);
                }
            }
        }
        Commands.AddRange(registry.Commands.FindAll((x) => RequireCommands.Exists(x.Name.Equals)));
    }

    internal static void ParseFeatures(GLRegistry registry, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string api = GLRegistry.ParseString(nav.Select("./@api"));
            string name = GLRegistry.ParseString(nav.Select("./@name"));
            string number = GLRegistry.ParseString(nav.Select("./@number"));
            GLRFeature feature = new() {
                API = api,
                Name = name,
                Number = number
            };
            registry.Features.Add(feature);

            XPathNodeIterator rit = nav.Select("./require");
            while (rit != null && rit.MoveNext()) {
                XPathNavigator rnav = rit.Current.CreateNavigator();
                string profile = GLRegistry.ParseString(rnav.Select("./@profile"));
                if (!string.IsNullOrEmpty(profile) && !profile.Equals("compatibility")) {
                    ParseName(feature.RequiredTypes, rnav.Select("./type"));
                    ParseName(feature.RequireEnums, rnav.Select("./enum"));
                    ParseName(feature.RequireCommands, rnav.Select("./command"));
                } else if (string.IsNullOrEmpty(profile)) {
                    ParseName(feature.RequiredTypes, rnav.Select("./type"));
                    ParseName(feature.RequireEnums, rnav.Select("./enum"));
                    ParseName(feature.RequireCommands, rnav.Select("./command"));
                }
            }
            ParseName(feature.RemoveCommands, nav.Select("./remove/command"));
            ParseName(feature.RemoveEnums, nav.Select("./remove/enum"));
        }
        registry.Features.TrimExcess();
    }

    static void ParseName(List<string> output, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string name = GLRegistry.ParseString(nav.Select("./@name"));
            if (!output.Exists((x) => x.Equals(name))) {
                output.Add(name);
            }
        }
        output.TrimExcess();
    }

    public object Clone() {
        GLRFeature result = new() {
            API = !string.IsNullOrEmpty(API) ? API.Clone() as string : API,
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Number = !string.IsNullOrEmpty(Number) ? Number.Clone() as string : Number
        };
        result.RequireEnums.AddRange(RequireEnums);
        result.RequireEnums.TrimExcess();
        result.RequireCommands.AddRange(RequireCommands);
        result.RequireCommands.TrimExcess();
        result.RequiredTypes.AddRange(RequiredTypes);
        result.RequiredTypes.TrimExcess();
        result.RemoveEnums.AddRange(RemoveEnums);
        result.RemoveEnums.TrimExcess();
        result.RemoveCommands.AddRange(RemoveCommands);
        result.RemoveCommands.TrimExcess();
        return result;
    }

    public override string ToString() => Name;
}
