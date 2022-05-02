namespace glregistry;

public class GLRGroup : ICloneable {
    GLRegistry m_registry;
    List<GLREnumerant> m_enumerants;

    /// <summary>
    /// Name of the group.
    /// </summary>
    public string Name;
    /// <summary>
    /// Data type of the values of enumerants in this group.
    /// </summary>
    public string Type;
    /// <summary>
    /// A vendor or purpose for the reserved range in start and end.
    /// </summary>
    public string Vendor;
    /// <summary>
    /// Start of the value range to reserve.
    /// </summary>
    public string Start;
    /// <summary>
    /// End of the value range to reserve.
    /// </summary>
    public string End;
    /// <summary>
    /// A list of enumerants defined by this group.
    /// </summary>
    public IReadOnlyList<GLREnumerant> Enums { get => m_enumerants; }

    public GLRGroup() {
        m_enumerants = new();
    }

    /// <summary>
    /// Check if an enumerant exists within this group.
    /// </summary>
    /// <param name="enumName">Name of the enumerant to look for.</param>
    /// <returns>True if the group contains the specified enumerant name, false if it does not.</returns>
    public bool ContainsEnum(string enumName) => m_enumerants.Exists((x) => x.Name == enumName);
    /// <summary>
    /// Check if an enumerant exists within this group.
    /// </summary>
    /// <param name="enumerant">The enumerant to look for.</param>
    /// <returns>True if the group contains the specified enumerant name, false if it does not.</returns>
    public bool ContainsEnum(GLREnumerant enumerant) => m_enumerants.Contains(enumerant);

    /// <summary>
    /// Add one or more enumerants to the list, ignores duplicates.
    /// </summary>
    /// <param name="enums">One or more enumerants to be added.</param>
    /// <returns>Amount of enumerants that were added.</returns>
    public int AddEnums(params GLREnumerant[] enums) {
        if (enums != null) {
            GLREnumerant[] matches = Array.FindAll(enums, (x) => !ContainsEnum(x.Name));
            m_enumerants.AddRange(matches);
            return (matches != null) ? matches.Length : 0;
        }
        return 0;
    }

    /// <summary>
    /// Remove one or more enumerants from the list.
    /// </summary>
    /// <param name="enums">One or more enumerants to be removed.</param>
    /// <returns>Amount of enumerants that were removed.</returns>
    public int RemoveEnums(params GLREnumerant[] enums) {
        if (enums != null) {
            return m_enumerants.RemoveAll((x) => Array.Exists(enums, ContainsEnum));
        }
        return 0;
    }

    /// <summary>
    /// Update this group's references to the specified registry.
    /// </summary>
    /// <param name="registry">The registry to fetch references from.</param>
    /// <param name="updateEnumerants">Should enumerants be updated as well?</param>
    public void Update(GLRegistry registry, bool updateEnumerants = true) {
        m_registry = registry;
        if (updateEnumerants) {
            foreach (GLREnumerant enumerant in m_enumerants) {
                enumerant.Update(registry);
            }
        }
    }

    public static void ParseEnumGroups(GLRegistry registry, XPathNodeIterator it) {
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

            GLRGroup enumGroup = registry.EnumGroups.Find((x) => x.Name.Equals(group));
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
            GLREnumerant.ParseEnumValue(enumGroup, nav.Select("./enum"));
        }
        registry.EnumGroups.TrimExcess();
    }

    public object Clone() => Clone(null);

    public GLRGroup Clone(GLRegistry registry) {
        GLRGroup result = new() {
            Name = !string.IsNullOrEmpty(Name) ? Name.Clone() as string : Name,
            Type = !string.IsNullOrEmpty(Type) ? Type.Clone() as string : Type,
            Vendor = !string.IsNullOrEmpty(Vendor) ? Vendor.Clone() as string : Vendor,
            Start = !string.IsNullOrEmpty(Start) ? Start.Clone() as string : Start,
            End = !string.IsNullOrEmpty(End) ? End.Clone() as string : End
        };

        foreach (GLREnumerant enumerant in m_enumerants) {
            result.AddEnums(enumerant.Clone(registry));
        }

        if (registry != null) {
            result.Update(registry, false);
        }

        return result;
    }

    public override string ToString() => Name;
}
