namespace glregistry;

public static class ExtensionMethods {
    #region List<T> Methods

    public static List<T> Clone<T>(this List<T> list)
        where T : class, ICloneable {
        List<T> result = new();
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            result.Add(list[i].Clone() as T);
        }
        return result;
    }

    public static bool Contains<T>(this List<T> list, string name)
        where T : INamedObject {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            if (list[i].Name == name) {
                return true;
            }
        }
        return false;
    }

    public static T Find<T>(this List<T> list, string name)
        where T : INamedObject {
        T result = default;
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            if (list[i].Name == name) {
                result = list[i];
                break;
            }
        }
        return result;
    }

    public static List<T> FindAllEx<T>(this List<T> list, Predicate<T> comparand)
        where T : INamedObject {
        List<T> result = new();
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            if (comparand(list[i])) {
                result.Add(list[i]);
            }
        }
        return result;
    }

    #endregion

    #region UpdateReferences<T>(GLregistry registry) where T : class, IReferenceHolder

    public static void UpdateReferences<T>(this List<T> list, GLregistry registry)
        where T : class, IReferenceHolder {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    public static void UpdateReferences<T>(this List<GLreference<T>> list, GLregistry registry)
        where T : class, INamedObject, IReferenceHolder {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateReferences(registry);
        }
    }

    #endregion

    public static void UpdateCode<T>(this List<T> list) 
        where T : class, ICodeProvider {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateCode();
        }
    }

    // public static void UpdateCode(this List<GLgroup> list) {
    //     int count = list.Count;
    //     for (int i = 0; i < count; i++) {
    //         list[i].UpdateCode();
    //     }
    // }

}
