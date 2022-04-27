[StructLayout(LayoutKind.Sequential)]
public struct GLprogram : IEquatable<GLprogram>, IEquatable<GLuint> {
    public static readonly GLprogram Null = default;

    readonly GLuint m_handle;

    internal GLprogram(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLprogram>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLprogram objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLprogram other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLprogram a, GLprogram b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLprogram a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLprogram b) => a.Equals(b.m_handle);

    public static bool operator !=(GLprogram a, GLprogram b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLprogram a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLprogram b) => !a.Equals(b.m_handle);

    public static implicit operator GLuint(GLprogram obj) => obj.m_handle;
    public static explicit operator GLprogram(GLuint handle) => new(handle);

    #endregion
}