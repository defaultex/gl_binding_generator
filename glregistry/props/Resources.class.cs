namespace glregistry;

public static partial class Resources {

    public const string ObjectName = "GL{0}";

    public const string ObjectFolder = OutputFolder + "/objects";
    public const string ObjectFilename = ObjectFolder + "/GL{0}.cs";

    public const string ObjectFormat = @"[StructLayout(LayoutKind.Sequential)]
public struct " + ObjectName + @" : IEquatable<" + ObjectName + @">, IEquatable<GLuint> {{
    public static readonly " + ObjectName + @" Null = default;

    readonly GLuint m_handle;

    internal " + ObjectName + @"(GLuint handle) {{
        m_handle = handle;
    }}

    #region IEquatable<" + ObjectName + @">, IEquatable<GLuint>

    public override bool Equals(object obj) {{
        if (obj is " + ObjectName + @" objHandle) {{
            return Equals(objHandle);
        }}
        if (obj is GLuint handle) {{
            return Equals(handle);
        }}
        return base.Equals(obj);
    }}
    public bool Equals(" + ObjectName + @" other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(" + ObjectName + @" a, " + ObjectName + @" b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(" + ObjectName + @" a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, " + ObjectName + @" b) => a.Equals(b.m_handle);

    public static bool operator !=(" + ObjectName + @" a, " + ObjectName + @" b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(" + ObjectName + @" a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, " + ObjectName + @" b) => !a.Equals(b.m_handle);

    public static implicit operator GLuint(" + ObjectName + @" obj) => obj.m_handle;
    public static explicit operator " + ObjectName + @"(GLuint handle) => new(handle);

    #endregion
}}";

}