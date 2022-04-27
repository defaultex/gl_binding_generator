[StructLayout(LayoutKind.Sequential)]
public struct GLprogrampipeline : IEquatable<GLprogrampipeline>, IEquatable<GLuint> {
    public static readonly GLprogrampipeline Null = default;

    readonly GLuint m_handle;

    internal GLprogrampipeline(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLprogrampipeline>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLprogrampipeline objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLprogrampipeline other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLprogrampipeline a, GLprogrampipeline b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLprogrampipeline a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLprogrampipeline b) => a.Equals(b.m_handle);

    public static bool operator !=(GLprogrampipeline a, GLprogrampipeline b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLprogrampipeline a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLprogrampipeline b) => !a.Equals(b.m_handle);

    public static implicit operator GLuint(GLprogrampipeline obj) => obj.m_handle;
    public static explicit operator GLprogrampipeline(GLuint handle) => new(handle);

    #endregion
}