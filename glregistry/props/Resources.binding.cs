using System.Reflection;

namespace glregistry;

public static partial class Resources {
    // /// <summary>
    // /// Bind the wrapper to the current context.
    // /// </summary>
    // /// <param name="extensions">An optional list of extension names paired with a static type to bind static function pointers.</param>
    // public static void BindToContext(Func<string, IntPtr> getProcAddr, Func<string, bool> isExtensionSupported = null, (string, Type)[] extensions = null) {
    //     foreach (FieldInfo field in typeof(gl.Functions).GetFields(BindingFlags.Public | BindingFlags.Static)) {
    //         IntPtr procAddress = getProcAddr(field.Name);
    //         Debug.Assert(procAddress != default, string.Format("'{0}' could not be bound to the current context", field.Name));
    //         field.SetValue(null, procAddress);
    //     }
    //     if (extensions != null) {
    //         foreach ((string, Type) extension in extensions) {
    //             LoadExtension(getProcAddr, isExtensionSupported, extension.Item1, extension.Item2);
    //         }
    //     }
    // }

    // static void LoadExtension(Func<string, IntPtr> getProcAddr, Func<string, bool> isExtensionSupported, string extensionName, Type ptrFuncDefs) {
    //     _ = extensionName ?? throw new ArgumentNullException(nameof(extensionName));
    //     _ = ptrFuncDefs ?? throw new ArgumentNullException(nameof(ptrFuncDefs));
    //     if (isExtensionSupported(extensionName)) {
    //         foreach (FieldInfo field in ptrFuncDefs.GetFields(BindingFlags.Public | BindingFlags.Static)) {
    //             IntPtr procAddress = getProcAddr(field.Name);
    //             Debug.Assert(procAddress != default, string.Format("'{0}' could not be bound to the current context", field.Name));
    //             field.SetValue(null, procAddress);
    //         }
    //     }
    // }
}