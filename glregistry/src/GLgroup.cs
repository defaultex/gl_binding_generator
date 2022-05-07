namespace glregistry;

/// <summary>
/// Represents a group of enumerants with a definitive name.
/// </summary>
public class GLgroup : INamedObject, IReferenceHolder, ICodeProvider, ICloneable {
    GLregistry m_registry;
    string m_cDecl, m_csDecl, m_headerGuard, m_firstOccurence;

    /// <summary>
    /// Namespace this group is defined for.
    /// </summary>
    [XmlAttribute("namespace")]
    public string Namespace;

    /// <summary>
    /// Name of the group.
    /// </summary>
    [XmlAttribute("group")]
    public string Name { get; init; }

    /// <summary>
    /// Data type of the values of enumerants in this group.
    /// </summary>
    [XmlAttribute("type")]
    public string Type;

    /// <summary>
    /// Start of the value range to reserve.
    /// </summary>
    [XmlAttribute("start")]
    public string Start;

    /// <summary>
    /// End of the value range to reserve.
    /// </summary>
    [XmlAttribute("end")]
    public string End;

    /// <summary>
    /// A vendor or purpose for the reserved range in start and end.
    /// </summary>
    [XmlAttribute("vendor")]
    public string Vendor;

    /// <summary>
    /// A list of enumerants defined by this group.
    /// </summary>
    [XmlElement("enum")]
    public List<GLenumerant> Enumerants { get; init; } = new();

    /// <summary>
    /// Parameters configured to produce a header guard.
    /// </summary>
    [XmlIgnore]
    public string HeaderGuard { get => m_headerGuard; }

    /// <summary>
    /// First feature or extension the group appears in.
    /// </summary>
    [XmlIgnore]
    public string FirstOccurence { get => m_firstOccurence; }

    /// <summary>
    /// A string containing the full declaration in C.
    /// </summary>
    [XmlIgnore]
    public string CDecl { get => m_cDecl; }

    /// <summary>
    /// A string containing the full declaration in C#.
    /// </summary>
    [XmlIgnore]
    public string CSDecl { get => m_csDecl; }

    /// <summary>
    /// Add one or more enumerants to the group, ignores duplicates.
    /// </summary>
    /// <param name="enumerants">One or more enumerants to be added.</param>
    /// <returns>Amount of enumerants that were added.</returns>
    public int AddEnums(params GLenumerant[] enumerants) {
        int addCount = 0;
        if (enumerants != null) {
            int enumsCount = enumerants.Length;
            for (int i = 0; i < enumsCount; i++) {
                if (!Enumerants.Contains(enumerants[i])) {
                    Enumerants.Add(enumerants[i]);
                    addCount++;
                }
            }
        }
        return addCount;
    }

    /// <summary>
    /// Remove one or more enumerants from the group.
    /// </summary>
    /// <param name="enumerants">One or more enumerants to be removed.</param>
    /// <returns>Amount of enumerants that were removed.</returns>
    public int RemoveEnums(params GLenumerant[] enumerants) {
        int removeCount = 0;
        if (enumerants != null) {
            int enumsCount = enumerants.Length;
            for (int i = 0; i < enumsCount; i++) {
                if (Enumerants.Remove(enumerants[i])) {
                    removeCount++;
                }
            }
        }
        return removeCount;
    }

    /// <summary>
    /// Update the group's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public void UpdateReferences(GLregistry registry) {
        m_registry = registry;
        Enumerants.UpdateReferences(registry);
    }

    public void UpdateCode() {
        if (string.IsNullOrEmpty(Name)) {
            return;
        }

        m_cDecl = string.Empty; 
        m_csDecl = string.Empty;
        
        if (Name.EndsWith("Mask")) {
            m_csDecl = string.Format("[Flags]\npublic enum {0} : GLbitfield {{\n", Name);
        } else {
            m_csDecl = string.Format("public enum {0} : GLenum {{\n", Name);
        }

        int ncount = Enumerants.Count;
        for (int i = 0; i < ncount; i++) {
            GLenumerant enumerants = Enumerants[i];
            enumerants.UpdateCode();
            m_cDecl += string.Format("{0} \n", enumerants.CDecl);
            m_csDecl += string.Format("    {0} = {1}.Constants.{2},\n", enumerants.CSName, enumerants.API, enumerants.Name);
        }
        m_csDecl += "}";



        m_firstOccurence = null;
        m_headerGuard = string.Empty;
        if (m_registry == null) {
            return;
        }

        List<string> apis = new();

        // find all of the features the group appears in
        int fcount = m_registry.Features.Count;
        for (int i = 0; i < fcount; i++) {
            GLfeature feature = m_registry.Features[i];

            int rcount = feature.Require.Count;
            for (int j = 0; j < rcount; j++) {
                GLdepends req = feature.Require[j];

                int ccount = req.Commands.Count;
                for (int k = 0; k < ccount; k++) {
                    GLcommand command = req.Commands[k].Reference;

                    if (!string.IsNullOrEmpty(command.Prototype.Group) && m_registry.Groups.Contains(command.Prototype.Group)) {
                        if (!string.IsNullOrEmpty(m_firstOccurence)) {
                            m_firstOccurence = feature.Name;
                        } else if (!apis.Contains(feature.Name)) {
                            apis.Add(feature.Name);
                        }
                    }

                    int pcount = command.Parameters.Count;
                    for (int l = 0; l < pcount; l++) {
                        GLprototype parameter = command.Parameters[l];

                        if (!string.IsNullOrEmpty(parameter.Group) && m_registry.Groups.Contains(parameter.Group)) {
                            if (!string.IsNullOrEmpty(m_firstOccurence)) {
                                m_firstOccurence = feature.Name;
                            } else if (!apis.Contains(feature.Name)) {
                                apis.Add(feature.Name);
                            }
                        }
                    }
                }

                if (req.Enumerants.Contains(Name) && !apis.Contains(feature.Name)) {
                    if (!string.IsNullOrEmpty(m_firstOccurence)) {
                        m_firstOccurence = feature.Name;
                    } else if (!apis.Contains(feature.Name)) {
                        apis.Add(feature.Name);
                    }
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

                int ccount = req.Commands.Count;
                for (int k = 0; k < ccount; k++) {
                    GLcommand command = req.Commands[k].Reference;

                    if (!string.IsNullOrEmpty(command.Prototype.Group) && m_registry.Groups.Contains(command.Prototype.Group)) {
                        if (!string.IsNullOrEmpty(m_firstOccurence)) {
                            m_firstOccurence = extension.Name;
                        } else if (!apis.Contains(extension.Name)) {
                            apis.Add(extension.Name);
                        }
                    }

                    int pcount = command.Parameters.Count;
                    for (int l = 0; l < pcount; l++) {
                        GLprototype parameter = command.Parameters[l];

                        if (!string.IsNullOrEmpty(parameter.Group) && m_registry.Groups.Contains(parameter.Group)) {
                            if (!string.IsNullOrEmpty(m_firstOccurence)) {
                                m_firstOccurence = extension.Name;
                            } else if (!apis.Contains(extension.Name)) {
                                apis.Add(extension.Name);
                            }
                        }
                    }
                }

                if (req.Enumerants.Contains(Name) && !apis.Contains(extension.Name)) {
                    if (string.IsNullOrEmpty(m_firstOccurence)) {
                        m_firstOccurence = extension.Name;
                    } else if (!apis.Contains(extension.Name)) {
                        apis.Add(extension.Name);
                    }
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
    /// Clone the group with existing references or references into the specified registry.
    /// </summary>
    /// <param name="registry">A registry to clone the enumerant into or null for keep references.</param>
    public GLgroup Clone(GLregistry registry = null) {
        GLgroup result = new() {
            Name = Name,
            Type = Type,
            Start = Start,
            End = End,
            Vendor = Vendor,
            Enumerants = Enumerants.Clone()
        };
        result.UpdateReferences(registry ?? m_registry);
        return result;
    }

    public override string ToString() => Name;
}