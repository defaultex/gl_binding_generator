[StructLayout(LayoutKind.Sequential)]
public struct GLframebuffer : IEquatable<GLframebuffer>, IEquatable<GLuint> {
    public static readonly GLframebuffer Null = default;

    readonly GLuint m_handle;

    internal GLframebuffer(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLframebuffer>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLframebuffer objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLframebuffer other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLframebuffer a, GLframebuffer b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLframebuffer a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLframebuffer b) => a.Equals(b.m_handle);

    public static bool operator !=(GLframebuffer a, GLframebuffer b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLframebuffer a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLframebuffer b) => !a.Equals(b.m_handle);

    public static explicit operator GLuint(GLframebuffer obj) => obj.m_handle;
    public static explicit operator GLframebuffer(GLuint handle) => new(handle);

    #endregion
}