[StructLayout(LayoutKind.Sequential)]
public struct GLtransformfeedback : IEquatable<GLtransformfeedback>, IEquatable<GLuint> {
    public static readonly GLtransformfeedback Null = default;

    readonly GLuint m_handle;

    internal GLtransformfeedback(GLuint handle) {
        m_handle = handle;
    }

    #region IEquatable<GLtransformfeedback>, IEquatable<GLuint>

    public override bool Equals(object obj) {
        if (obj is GLtransformfeedback objHandle) {
            return Equals(objHandle);
        }
        if (obj is GLuint handle) {
            return Equals(handle);
        }
        return base.Equals(obj);
    }
    public bool Equals(GLtransformfeedback other) => m_handle.Equals(other.m_handle);
    public bool Equals(GLuint other) => m_handle.Equals(other);
    public override int GetHashCode() => m_handle.GetHashCode();
    public override string ToString() => m_handle.ToString();

    public static bool operator ==(GLtransformfeedback a, GLtransformfeedback b) => a.m_handle.Equals(b.m_handle);
    public static bool operator ==(GLtransformfeedback a, GLuint b) => a.m_handle.Equals(b);
    public static bool operator ==(GLuint a, GLtransformfeedback b) => a.Equals(b.m_handle);

    public static bool operator !=(GLtransformfeedback a, GLtransformfeedback b) => !a.m_handle.Equals(b.m_handle);
    public static bool operator !=(GLtransformfeedback a, GLuint b) => !a.m_handle.Equals(b);
    public static bool operator !=(GLuint a, GLtransformfeedback b) => !a.Equals(b.m_handle);

    public static explicit operator GLuint(GLtransformfeedback obj) => obj.m_handle;
    public static explicit operator GLtransformfeedback(GLuint handle) => new(handle);

    #endregion
}