[StructLayout(LayoutKind.Sequential)]
public struct GLsync : IEquatable<GLsync>, IEquatable<GLuint> {
    public static readonly GLsync Null = default;

    readonly GLuint m_handle;

    internal GLsync(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLsync>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLsync objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLsync other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLsync a, GLsync b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLsync a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLsync b) => a.Equals(b.m_handle);

    public static bool operator !=(GLsync a, GLsync b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLsync a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLsync b) => !a.Equals(b.m_handle);

    public static implicit operator GLuint(GLsync obj) => obj.m_handle;
    public static explicit operator GLsync(GLuint handle) => new(handle);

    #endregion
}