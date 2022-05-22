namespace HGL;

public static partial class hgl {
    const string GL_DLL = @"/usr/lib/x86_64-linux-gnu/libGL.so";

    /// <summary>
    /// Bind the wrapper to the current context.
    /// </summary>
    /// <param name="getProcAddr">Delegate pointing at a GetProcAddress() function.</param>
    /// <param name="isExtensionSupported">Delegate pointing at a function to determine if an extension is supported.</param>
    /// <param name="extensions">An optional list of extension names paired with a static type to bind static function pointers.</param>
    public static void BindToContext(Func<string, IntPtr> getProcAddr, Func<string, bool> isExtensionSupported, (string, Type)[] extensions = null) {
        _ = getProcAddr ?? throw new ArgumentNullException(nameof(getProcAddr));

        foreach (FieldInfo field in typeof(gl.Functions).GetFields(BindingFlags.Public | BindingFlags.Static)) {
            BindFunction(field, getProcAddr);
        }

        if (extensions != null && isExtensionSupported != null) {
            foreach ((string, Type) extension in extensions) {
                LoadExtension(getProcAddr, isExtensionSupported, extension.Item1, extension.Item2);
            }
        }
    }

    static void LoadExtension(Func<string, IntPtr> getProcAddr, Func<string, bool> isExtensionSupported, string extensionName, Type ptrFuncDefs) {
        _ = extensionName ?? throw new ArgumentNullException(nameof(extensionName));
        _ = ptrFuncDefs ?? throw new ArgumentNullException(nameof(ptrFuncDefs));

        if (isExtensionSupported(extensionName)) {
            foreach (FieldInfo field in ptrFuncDefs.GetFields(BindingFlags.Public | BindingFlags.Static)) {
                BindFunction(field, getProcAddr);
            }
        }
    }

    static void BindFunction(FieldInfo field, Func<string, IntPtr> getProcAddr) {
        IntPtr procAddress = getProcAddr(field.Name);
        _ = (procAddress == IntPtr.Zero) ? throw new InvalidOperationException($"Unable to get an address for '{field.Name}'.") : 0;

        field.SetValue(null, procAddress);

        // validate the bindings
        IntPtr storedAddress = (IntPtr)field.GetValue(null);
        if (storedAddress != procAddress) {
            Trace.WriteLine($"GL binding for '{field.Name}' failed validation. Target Address = '{procAddress}', Stored Address = '{storedAddress}'");
        }
    }
}