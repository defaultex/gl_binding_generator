namespace glregistry;

/// <summary>
/// Interface used by objects which are named.
/// </summary>
public interface INamedObject {
    /// <summary>
    /// Name used to refer to the object.
    /// </summary>
    string Name { get; }
}

/// <summary>
/// Interface for objects which can provide source code snippets.
/// </summary>
public interface ICodeProvider {
    /// <summary>
    /// C-syntax declaration of the object.
    /// </summary>
    string CDecl { get; }
    /// <summary>
    /// C#-syntax declaration of the object.
    /// </summary>
    string CSDecl { get; }

    /// <summary>
    /// Updates the code snippets provided by the object.
    /// </summary>
    void UpdateCode();
}
