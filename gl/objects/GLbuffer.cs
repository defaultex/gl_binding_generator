[StructLayout(LayoutKind.Sequential)]
public struct GLbuffer : IEquatable<GLbuffer>, IEquatable<GLuint> {
    public static readonly GLbuffer Null = default;

    readonly GLuint m_handle;

    internal GLbuffer(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLbuffer>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLbuffer objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLbuffer other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLbuffer a, GLbuffer b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLbuffer a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLbuffer b) => a.Equals(b.m_handle);

    public static bool operator !=(GLbuffer a, GLbuffer b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLbuffer a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLbuffer b) => !a.Equals(b.m_handle);

    public static explicit operator GLuint(GLbuffer obj) => obj.m_handle;
    public static explicit operator GLbuffer(GLuint handle) => new(handle);

    #endregion
}