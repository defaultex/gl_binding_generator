namespace glregistry;

/// <summary>
/// Represents a constant within the OpenGL specification.
/// </summary>
public class GLenumerant : INamedObject, IReferenceHolder, ICodeProvider, ICloneable {
    GLregistry m_registry;
    IEnumerable<GLgroup> m_groupsList;
    List<string> m_groupNames = new();
    string m_cDecl, m_csName, m_csDecl, m_headerGuard, m_firstOccurence;

    /// <summary>
    /// Value of the enumerant, a C-style constant.
    /// </summary>
    [XmlAttribute("value")]
    public string Value;

    /// <summary>
    /// Name of the enumerant.
    /// </summary>
    [XmlAttribute("name")]
    public string Name{ get; init; }

    /// <summary>
    /// An API name that specializes the enumerant so that different APIs may have
    /// different values for the same enumerant.
    /// </summary>
    [XmlAttribute("api")]
    public string API;

    /// <summary>
    /// C-specific type for the enumerant.
    /// </summary>
    [XmlAttribute("type")]
    public string Type;

    /// <summary>
    /// One or more group names the enumerant is found in.
    /// </summary>
    [XmlAttribute("group")]
    public string Group {
        get => string.Join(',', m_groupNames);
        set {
            m_groupNames.Clear();
            if (!string.IsNullOrEmpty(value)) {
                if (value.IndexOf(',') >= 0) {
                    m_groupNames.AddRange(value.Split(','));
                } else {
                    m_groupNames.Add(value);
                }
            }
        }
    }

    /// <summary>
    /// Registry the enumerant fetches it's references from.
    /// </summary>
    [XmlIgnore]
    public GLregistry Registry { get => m_registry; }

    /// <summary>
    /// Groups referenced by the enumerant.
    /// </summary>
    [XmlIgnore]
    public IEnumerable<GLgroup> GroupsRef { get => m_groupsList; }

    /// <summary>
    /// names of groups referenced by the enumerant.
    /// </summary>
    [XmlIgnore]
    public IEnumerable<string> Groups { get => m_groupNames; }

    /// <summary>
    /// Name converted into camel hump notation.
    /// </summary>
    [XmlIgnore]
    public string CSName { get => m_csName; }

    /// <summary>
    /// Enumerant represented as a C constant.
    /// </summary>
    [XmlIgnore]
    public string CDecl { get => m_cDecl; }

    /// <summary>
    /// Enumerant represented as a C# constant.
    /// </summary>
    [XmlIgnore]
    public string CSDecl { get => m_csDecl; }

    /// <summary>
    /// Parameters configured to produce a header guard.
    /// </summary>
    [XmlIgnore]
    public string HeaderGuard { get => m_headerGuard; }

    /// <summary>
    /// First feature or extension the enumerant appears in.
    /// </summary>
    [XmlIgnore]
    public string FirstOccurence { get => m_firstOccurence; }

    /// <summary>
    /// Check if a group exists within the enumerant's groups.
    /// </summary>
    /// <param name="groupName">Name of the group to look for.</param>
    /// <returns>True if the enumerant's groups contains the specified name, false if it does not.</returns>
    public bool ContainsGroup(string groupName) => m_groupNames.Contains(groupName);

    /// <summary>
    /// Add one or more groups to the enumerant, ignores duplicates.
    /// </summary>
    /// <param name="groups">One or more groups to be added.</param>
    /// <returns>Amount of groups that were added.</returns>
    public int AddGroups(params string[] groups) {
        int addCount = 0;
        for (int i = 0; i < groups.Length; i++) {
            if (!ContainsGroup(groups[i])) {
                m_groupNames.Remove(groups[i]);
                addCount++;
            }
        }
        return addCount;
    }

    /// <summary>
    /// Remove one or more groups from the enumerant.
    /// </summary>
    /// <param name="groups">One or more groups to be removed.</param>
    /// <returns>Amount of groups that were removed.</returns>
    public int RemoveGroups(params string[] groups) {
        int remCount = 0;
        for (int i = 0; i < groups.Length; i++) {
            if (m_groupNames.Remove(groups[i])) {
                remCount++;
            }
        }
        return remCount;
    }

    /// <summary>
    /// Update the enumerant's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        m_groupsList = null;
        if (registry != null) {
            // find the groups that match the group names
            m_groupsList = registry.Groups.FindAllEx(x => ContainsGroup(x.Name));
        }
    }

    public void UpdateCode() {
        m_cDecl = string.Format("#define {0} {1}", Name, Value);
        m_csName = string.Empty;

        // process the spec's naming to produce a reasonable C# equivalent
        string[] nameWords = Name.Split('_');
        for (int i = 1; i < nameWords.Length; i++) {
            if (i == nameWords.Length - 1 && Resources.SkipWords.Contains(nameWords[i])) {
                // skip over words like BIT and BITS
                continue;
            }

            if (Resources.DimensionSpec.Contains(nameWords[i])) {
                // don't adjust dimension spec, just reads badly
                m_csName += nameWords[i];
            } else {
                // caps to camel hump conversion
                m_csName += string.Format("{0}{1}", nameWords[i][0], nameWords[i].Substring(1).ToLower());
            }
        }

        if (!string.IsNullOrEmpty(m_csName)) {
            // the value name starts with a number, just prefix it with an underscore
            if (Resources.Base10Digits.Contains(m_csName[0])) {
                m_csName = "_" + m_csName;
            }
        } else {
            // couldn't process the name so just use it as is
            m_csName = Name;
        }

        string type = "GLenum";
        if (Name.EndsWith("_BIT") || Name.EndsWith("_BITS")) {
            type = "GLbitfield";
        } else if (Name == "GL_TIMEOUT_IGNORED") {
            type = "GLuint64";
        }
        m_csDecl = string.Format(Resources.ConstantsDefinition, Name, Value, type);

        m_firstOccurence = null;
        m_headerGuard = string.Empty;
        if (m_registry == null) {
            return;
        }

        List<string> apis = new();

        // find all of the features the enumerant appears in
        int fcount = m_registry.Features.Count;
        for (int i = 0; i < fcount; i++) {
            GLfeature feature = m_registry.Features[i];

            int rcount = feature.Require.Count;
            for (int j = 0; j < rcount; j++) {
                GLdepends req = feature.Require[j];

                if (req.Enumerants.Contains(Name) && !apis.Contains(feature.Name)) {
                    // if (string.IsNullOrEmpty(m_firstOccurence)) {
                    m_firstOccurence = m_firstOccurence ?? feature.Name;
                    // } else {
                    apis.Add(feature.Name);
                    // }
                }
            }
        }

        // find all of the extensions the enumerant appears in
        int ecount = m_registry.Extensions.Count;
        for (int i = 0; i < ecount; i++) {
            GLextension extension = m_registry.Extensions[i];
            int rcount = extension.Require.Count;
            for (int j = 0; j < rcount; j++) {
                GLdepends req = extension.Require[j];
                if (req.Enumerants.Contains(Name) && !apis.Contains(extension.Name)) {
                    // if (string.IsNullOrEmpty(m_firstOccurence)) {
                    m_firstOccurence = m_firstOccurence ?? extension.Name;
                    // } else {
                    apis.Add(extension.Name);
                    // }
                }
            }
        }

        // use the api list to construct a header guard
        if (apis.Count > 0) {
            m_headerGuard = Generator.CreateHeaderGuard(apis, "||", false);
        }
    }

    object ICloneable.Clone() => Clone(null);

    /// <summary>
    /// Clone the enumerant with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to clone the enumerant into or null for keep references.</param>
    public GLenumerant Clone(GLregistry registry = null) {
        GLenumerant result = new() {
            Value = Value,
            Name = Name,
            API = API,
            Type = Type,
            Group = Group
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}