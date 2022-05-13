namespace glregistry;

public static class ExtensionMethods {

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

    public static void UpdateCode<T>(this List<T> list) 
        where T : class, ICodeProvider {
        int count = list.Count;
        for (int i = 0; i < count; i++) {
            list[i].UpdateCode();
        }
    }
    
}
