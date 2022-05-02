namespace glregistry;

public class GLRCommand : ICloneable {
    GLRegistry m_registry;
    List<GLRCommandParam> m_params;
    GLRCommand m_aliasedCommand;
    string m_funcDefC, m_funcDefCSharp;

    /// <summary>
    /// C-function prototype of the command.
    /// </summary>
    public string Prototype;
    /// <summary>
    /// Name of the command.
    /// </summary>
    public string Name;
    /// <summary>
    /// Name of the group that this command belongs to.
    /// </summary>
    public string Group;
    /// <summary>
    /// Name of another command this command is an alias for.
    /// </summary>
    public string Alias;
    /// <summary>
    /// A list of command parameters.
    /// </summary>
    public IReadOnlyList<GLRCommandParam> Params { get => m_params; }

    /// <summary>
    /// The registry this command fetches it's references from.
    /// </summary>
    public GLRegistry Registry { get => m_registry; }
    /// <summary>
    /// The command that this command is an alias for.
    /// </summary>
    public GLRCommand AliasedCommand { get => m_aliasedCommand; }
    /// <summary>
    /// Check if this command is an alias for another command.
    /// </summary>
    public bool IsAlias { get => !string.IsNullOrEmpty(Alias); }

    public GLRCommand() {
        m_params = new();
        m_funcDefCSharp = "";
        m_funcDefC = "";
    }

    /// <summary>
    /// Check if a parameter exists within this command.
    /// </summary>
    /// <param name="parameterName">Name of the parameter to look for.</param>
    /// <returns>True if the command contains the specified parameter, false if it does not.</returns>
    public bool ContainsParam(string parameterName) => m_params.Exists((x) => x.Name == parameterName);
    /// <summary>
    /// Check if a param exists within this command.
    /// </summary>
    /// <param name="parameter">The parameter to look for.</param>
    /// <returns>True if the command contains the specified parameter, false if it does not.</returns>
    public bool ContainsParam(GLRCommandParam parameter) => m_params.Contains(parameter);

    /// <summary>
    /// Add one or more parameters to the command, ignores duplicates.
    /// </summary>
    /// <param name="parameters">One or more parameters to be added.</param>
    /// <returns>Amount of parameters that were added.</returns>
    public int AddParams(params GLRCommandParam[] parameters) {
        if (parameters != null) {
            IEnumerable<GLRCommandParam> matches = from param in parameters
                                                   where !ContainsParam(param.Name)
                                                   select param;
            m_params.AddRange(matches);
            return (matches != null) ? matches.Count() : 0;
        }
        return 0;
    }

    /// <summary>
    /// Remove one or more parameters from the command.
    /// </summary>
    /// <param name="parameters">One or more parameters to be removed.</param>
    /// <returns>Amount of parameters that were removed.</returns>
    public int RemoveParams(params GLRCommandParam[] parameters) {
        if (parameters != null) {
            return m_params.RemoveAll((x) => parameters.Contains(x));
        }
        return 0;
    }

    /// <summary>
    /// Update this command and all of it's parameter's references to the specified registry.
    /// </summary>
    /// <param name="registry">The registry to fetch references from.</param>
    /// <param name="updateParams">Should parameters be updated as well?</param>
    public void Update(GLRegistry registry, bool updateParams = true) {
        m_registry = registry;
        m_aliasedCommand = registry.Commands.Find((x) => x.Name == Alias);

        // create the function definition strings while updating parameters
        string returnType = Generator.ConvertType(Prototype.Replace(Name, null));
        string argsTypeCSharp = "";
        string argsTypeC = "";
        foreach (GLRCommandParam param in m_params) {
            if (updateParams) {
                param.Update(registry);
            }
            argsTypeCSharp += string.Format("{0} ,", param.ArgTypeCSharp);
            argsTypeC += string.Format("{0}, ", param.ArgTypeC);
        }
        if (!string.IsNullOrEmpty(argsTypeC)) {
            argsTypeC = argsTypeC.Substring(0, argsTypeC.LastIndexOf(','));
        }
        m_funcDefCSharp = string.Format(References.CommandSyntaxCSharp, returnType, Name, argsTypeCSharp);
        m_funcDefC = string.Format(References.CommandSyntaxC, returnType, Name, argsTypeC);
    }

    public static void ParseCommands(GLRegistry registry, XPathNodeIterator it) {
        while (it != null && it.MoveNext()) {
            XPathNavigator nav = it.Current.CreateNavigator();
            string alias = GLRegistry.ParseString(nav.Select("./alias/@name"));
            string prototype = GLRegistry.ParseString(nav.Select("./proto"));
            string name = GLRegistry.ParseString(nav.Select("./proto/name"));
            string group = GLRegistry.ParseString(nav.Select("./proto/@group"));
            name = (name != null) ? name.Trim() : name;
            if (string.IsNullOrEmpty(name) || registry.Commands.Exists((x) => x.Equals(name))) {
                continue;
            }
            GLRCommand command = new() {
                Name = name,
                Alias = (alias != null) ? alias.Trim() : alias,
                Prototype = (prototype != null) ? prototype.Trim() : prototype,
                Group = (group != null) ? group.Trim() : group
            };
            registry.Commands.Add(command);
            GLRCommandParam.ParseCommandParam(command, nav.Select("./param"));
        }
    }

    /// <summary>
    /// Clone a command and copy references to the clone.
    /// </summary>
    public object Clone() => Clone(null);

    /// <summary>
    /// Clone a command and update it's references to a new registry. 
    /// If registry is null then the command will copy references to the clone.
    /// </summary>
    /// <param name="registry">The new registry to fetch references from.</param>
    public GLRCommand Clone(GLRegistry registry) {
        GLRCommand result = new() {
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Alias = !string.IsNullOrEmpty(Alias) ? Alias.Clone() as string : Alias,
            Prototype = !string.IsNullOrEmpty(Prototype) ? Prototype.Clone() as string : Prototype,
            Group = !string.IsNullOrEmpty(Group) ? Group.Clone() as string : Group
        };

        foreach (GLRCommandParam param in m_params) {
            result.AddParams(param.Clone(registry));
        }

        if (registry != null) {
            result.Update(registry, false);
        } else {
            result.m_aliasedCommand = m_aliasedCommand;
            result.m_funcDefCSharp = m_funcDefCSharp;
            result.m_funcDefC = m_funcDefC;
        }

        return result;
    }

    public override string ToString() => Name;
}
