[StructLayout(LayoutKind.Sequential)]
public struct GLsampler : IEquatable<GLsampler>, IEquatable<GLuint> {
    public static readonly GLsampler Null = default;

    readonly GLuint m_handle;

    internal GLsampler(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLsampler>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLsampler objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLsampler other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLsampler a, GLsampler b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLsampler a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLsampler b) => a.Equals(b.m_handle);

    public static bool operator !=(GLsampler a, GLsampler b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLsampler a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLsampler b) => !a.Equals(b.m_handle);

    public static explicit operator GLuint(GLsampler obj) => obj.m_handle;
    public static explicit operator GLsampler(GLuint handle) => new(handle);

    #endregion
}