[StructLayout(LayoutKind.Sequential)]
public struct GLquery : IEquatable<GLquery>, IEquatable<GLuint> {
    public static readonly GLquery Null = default;

    readonly GLuint m_handle;

    internal GLquery(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLquery>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLquery objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLquery other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLquery a, GLquery b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLquery a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLquery b) => a.Equals(b.m_handle);

    public static bool operator !=(GLquery a, GLquery b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLquery a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLquery b) => !a.Equals(b.m_handle);

    public static explicit operator GLuint(GLquery obj) => obj.m_handle;
    public static explicit operator GLquery(GLuint handle) => new(handle);

    #endregion
}