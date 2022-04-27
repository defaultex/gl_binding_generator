public class GLRExtension : ICloneable {
    public string Name;
    public List<string> SupportedAPIs;
    public List<string> RequireTypes;
    public List<string> RequireEnums;
    public List<string> RequireCommands;

    public List<GLREnumValue> Enums;
    public List<GLRCommand> Commands;

    public GLRExtension() {
        SupportedAPIs = new();
        RequireEnums = new();
        RequireCommands = new();
        RequireTypes = new();
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

    internal static void ParseExtensions(GLRegistry registry, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string name = GLRegistry.ParseString(nav.Select("./@name"));
            string supported = GLRegistry.ParseString(nav.Select("./@supported"));
            string[] supportedAPIs = !string.IsNullOrEmpty(supported) ? 
                (supported.IndexOf('|') >= 0) ? 
                supported.Split('|') 
                : new string[1] { supported } 
            : new string[0];

            GLRExtension extension = new() {
                Name = name
            };
            extension.SupportedAPIs.AddRange(supportedAPIs);
            extension.SupportedAPIs.TrimExcess();

            registry.Extensions.Add(extension);
            if (extension != null) {
                ParseName(extension.RequireTypes, nav.Select("./require/type"));
                ParseName(extension.RequireEnums, nav.Select("./require/enum"));
                ParseName(extension.RequireCommands, nav.Select("./require/command"));
            }
        }
        registry.Extensions.TrimExcess();
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
        GLRExtension result = new() {
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name
        };
        result.SupportedAPIs.AddRange(SupportedAPIs);
        result.SupportedAPIs.TrimExcess();
        result.RequireEnums.AddRange(RequireEnums);
        result.RequireEnums.TrimExcess();
        result.RequireCommands.AddRange(RequireCommands);
        result.RequireCommands.TrimExcess();
        result.RequireTypes.AddRange(RequireTypes);
        result.RequireTypes.TrimExcess();
        return result;
    }

    public override string ToString() => Name;
}
