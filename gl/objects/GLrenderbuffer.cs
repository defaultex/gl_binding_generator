[StructLayout(LayoutKind.Sequential)]
public struct GLrenderbuffer : IEquatable<GLrenderbuffer>, IEquatable<GLuint> {
    public static readonly GLrenderbuffer Null = default;

    readonly GLuint m_handle;

    internal GLrenderbuffer(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLrenderbuffer>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLrenderbuffer objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLrenderbuffer other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLrenderbuffer a, GLrenderbuffer b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLrenderbuffer a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLrenderbuffer b) => a.Equals(b.m_handle);

    public static bool operator !=(GLrenderbuffer a, GLrenderbuffer b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLrenderbuffer a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLrenderbuffer b) => !a.Equals(b.m_handle);

    public static explicit operator GLuint(GLrenderbuffer obj) => obj.m_handle;
    public static explicit operator GLrenderbuffer(GLuint handle) => new(handle);

    #endregion
}