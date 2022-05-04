namespace glregistry;

public static class ExtensionMethods {
    #region GLreference<T>.UpdateReferences(GLregistry registry)

    /// <summary>
    /// Update the type's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public static void UpdateReferences(this GLreference<GLtype> reference, GLregistry registry) {
        if (reference != null) {
            reference.m_registry = registry;
            if (registry != null) {
                reference.Reference = registry.Types.Find(reference.Name);
            }
        }
    }

    /// <summary>
    /// Update the enumerant's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public static void UpdateReferences(this GLreference<GLenumerant> reference, GLregistry registry) {
        if (reference != null) {
            reference.m_registry = registry;
            if (registry != null) {
                reference.Reference = registry.Enumerants.Find(reference.Name);
            }
        }
    }

    /// <summary>
    /// Update the group's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public static void UpdateReferences(this GLreference<GLgroup> reference, GLregistry registry) {
        if (reference != null) {
            reference.m_registry = registry;
            if (registry != null) {
                reference.Reference = registry.Groups.Find(reference.Name);
            }
        }
    }

    /// <summary>
    /// Update the command's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public static void UpdateReferences(this GLreference<GLcommand> reference, GLregistry registry) {
        if (reference != null) {
            reference.m_registry = registry;
            if (registry != null) {
                reference.Reference = registry.Commands.Find(reference.Name);
            }
        }
    }

    /// <summary>
    /// Update the feature's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public static void UpdateReferences(this GLreference<GLfeature> reference, GLregistry registry) {
        if (reference != null) {
            reference.m_registry = registry;
            if (registry != null) {
                reference.Reference = registry.Features.Find(reference.Name);
            }
        }
    }

    /// <summary>
    /// Update the extension's references to the specified registry or clear references.
    /// </summary>
    /// <param name="registry">A registry to fetch references from or null to clear references.</param>
    public static void UpdateReferences(this GLreference<GLextension> reference, GLregistry registry) {
        if (reference != null) {
            reference.m_registry = registry;
            if (registry != null) {
                reference.Reference = registry.Extensions.Find(reference.Name);
            }
        }
    }

    #endregion

    #region List<T>.Clone()

    public static List<GLtype> Clone(this List<GLtype> list) {
        if (list != null) {
            List<GLtype> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLenumerant> Clone(this List<GLenumerant> list) {
        if (list != null) {
            List<GLenumerant> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLgroup> Clone(this List<GLgroup> list) {
        if (list != null) {
            List<GLgroup> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLcommand> Clone(this List<GLcommand> list) {
        if (list != null) {
            List<GLcommand> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLfeature> Clone(this List<GLfeature> list) {
        if (list != null) {
            List<GLfeature> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLextension> Clone(this List<GLextension> list) {
        if (list != null) {
            List<GLextension> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLprototype> Clone(this List<GLprototype> list) {
        if (list != null) {
            List<GLprototype> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLdepends> Clone(this List<GLdepends> list) {
        if (list != null) {
            List<GLdepends> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone(null));
            }
        }
        return null;
    }

    public static List<GLreference<T>> Clone<T>(this List<GLreference<T>> list) {
        if (list != null) {
            List<GLreference<T>> result = new();
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                result.Add(list[i].Clone());
            }
        }
        return null;
    }

    #endregion

    #region List<T>.Contains(string name)

    public static bool Contains(this List<GLtype> list, string name) {
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool Contains(this List<GLenumerant> list, string name) {
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool Contains(this List<GLgroup> list, string name) {
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool Contains(this List<GLcommand> list, string name) {
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool Contains(this List<GLfeature> list, string name) {
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool Contains(this List<GLextension> list, string name) {
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool Contains(this List<GLprototype> list, string name) {
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    return true;
                }
            }
        }
        return false;
    }

    #endregion

    #region List<T>.Find(string name)

    public static GLtype Find(this List<GLtype> list, string name) {
        GLtype result = null;
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    result = list[i];
                    break;
                }
            }
        }
        return result;
    }

    public static GLenumerant Find(this List<GLenumerant> list, string name) {
        GLenumerant result = null;
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    result = list[i];
                    break;
                }
            }
        }
        return result;
    }

    public static GLgroup Find(this List<GLgroup> list, string name) {
        GLgroup result = null;
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    result = list[i];
                    break;
                }
            }
        }
        return result;
    }

    public static GLcommand Find(this List<GLcommand> list, string name) {
        GLcommand result = null;
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    result = list[i];
                    break;
                }
            }
        }
        return result;
    }

    public static GLfeature Find(this List<GLfeature> list, string name) {
        GLfeature result = null;
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    result = list[i];
                    break;
                }
            }
        }
        return result;
    }

    public static GLextension Find(this List<GLextension> list, string name) {
        GLextension result = null;
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (list[i].Name == name) {
                    result = list[i];
                    break;
                }
            }
        }
        return result;
    }

    #endregion

    #region List<T>.FindAllEx(Predicate<T> comparand)

    public static List<GLtype> FindAllEx(this List<GLtype> list, Predicate<GLtype> comparand) {
        List<GLtype> result = new();
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (comparand(list[i])) {
                    result.Add(list[i]);
                }
            }
        }
        return result;
    }

    public static List<GLenumerant> FindAllEx(this List<GLenumerant> list, Predicate<GLenumerant> comparand) {
        List<GLenumerant> result = new();
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (comparand(list[i])) {
                    result.Add(list[i]);
                }
            }
        }
        return result;
    }

    public static List<GLgroup> FindAllEx(this List<GLgroup> list, Predicate<GLgroup> comparand) {
        List<GLgroup> result = new();
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (comparand(list[i])) {
                    result.Add(list[i]);
                }
            }
        }
        return result;
    }

    public static List<GLcommand> FindAllEx(this List<GLcommand> list, Predicate<GLcommand> comparand) {
        List<GLcommand> result = new();
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (comparand(list[i])) {
                    result.Add(list[i]);
                }
            }
        }
        return result;
    }

    public static List<GLfeature> FindAllEx(this List<GLfeature> list, Predicate<GLfeature> comparand) {
        List<GLfeature> result = new();
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (comparand(list[i])) {
                    result.Add(list[i]);
                }
            }
        }
        return result;
    }

    public static List<GLextension> FindAllEx(this List<GLextension> list, Predicate<GLextension> comparand) {
        List<GLextension> result = new();
        if (list != null) {
            int count = list.Count;
            for (int i = 0; i < count; i++) {
                if (comparand(list[i])) {
                    result.Add(list[i]);
                }
            }
        }
        return result;
    }

    #endregion

    #region List<T>.UpdateReferences(GLregistry registry)

    public static void UpdateReferences(this List<GLtype> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLenumerant> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLcommand> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLgroup> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLfeature> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLextension> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLprototype> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLdepends> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLreference<GLtype>> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLreference<GLenumerant>> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences(this List<GLreference<GLcommand>> list, GLregistry registry) {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    #endregion
}
