[StructLayout(LayoutKind.Sequential)]
public struct GLdisplaylist : IEquatable<GLdisplaylist>, IEquatable<GLuint> {
    public static readonly GLdisplaylist Null = default;

    readonly GLuint m_handle;

    internal GLdisplaylist(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLdisplaylist>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLdisplaylist objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLdisplaylist other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLdisplaylist a, GLdisplaylist b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLdisplaylist a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLdisplaylist b) => a.Equals(b.m_handle);

    public static bool operator !=(GLdisplaylist a, GLdisplaylist b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLdisplaylist a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLdisplaylist b) => !a.Equals(b.m_handle);

    public static implicit operator GLuint(GLdisplaylist obj) => obj.m_handle;
    public static explicit operator GLdisplaylist(GLuint handle) => new(handle);

    #endregion
}