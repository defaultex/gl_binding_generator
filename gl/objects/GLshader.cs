[StructLayout(LayoutKind.Sequential)]
public struct GLshader : IEquatable<GLshader>, IEquatable<GLuint> {
    public static readonly GLshader Null = default;

    readonly GLuint m_handle;

    internal GLshader(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLshader>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLshader objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLshader other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLshader a, GLshader b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLshader a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLshader b) => a.Equals(b.m_handle);

    public static bool operator !=(GLshader a, GLshader b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLshader a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLshader b) => !a.Equals(b.m_handle);

    public static explicit operator GLuint(GLshader obj) => obj.m_handle;
    public static explicit operator GLshader(GLuint handle) => new(handle);

    #endregion
}