[StructLayout(LayoutKind.Sequential)]
public struct GLtexture : IEquatable<GLtexture>, IEquatable<GLuint> {
    public static readonly GLtexture Null = default;

    readonly GLuint m_handle;

    internal GLtexture(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLtexture>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLtexture objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLtexture other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLtexture a, GLtexture b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLtexture a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLtexture b) => a.Equals(b.m_handle);

    public static bool operator !=(GLtexture a, GLtexture b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLtexture a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLtexture b) => !a.Equals(b.m_handle);

    public static implicit operator GLuint(GLtexture obj) => obj.m_handle;
    public static explicit operator GLtexture(GLuint handle) => new(handle);

    #endregion
}