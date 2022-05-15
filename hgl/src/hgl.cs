public static partial class hgl {
    
    public static string GetString(GLString name) {
        unsafe { return Marshal.PtrToStringUTF8((IntPtr)gl.Functions.glGetString(name)); }
    }
    
    public static string GetString(GLString name, int index) {
        unsafe {
            return Marshal.PtrToStringUTF8((IntPtr)gl.Functions.glGetStringi(name, (GLuint)index));
        }
    }

    public static void GetMultisample(GLuint index, GLfloat[] value) {
        if (value != null && value.Length > 1) {
            unsafe {
                fixed (GLfloat* ptr = value) {
                    gl.Functions.glGetMultisamplefv(MultisampleParameter.SamplePosition, index, ptr);
                }
            }
        }
    }
    
    public static void GetMultisample(GLuint index, out GLfloat x, out GLfloat y) {
        x = y = default;
        unsafe {
            fixed (GLfloat* ptr = &x) {
                gl.Functions.glGetMultisamplefv(MultisampleParameter.SamplePosition, index, ptr);
            }
        }
    }
    
    public static void GetMultisample(GLuint index, out ValueTuple<GLfloat, GLfloat> value) {
        value = default;
        unsafe {
            fixed (GLfloat* ptr = &value.Item1) {
                gl.Functions.glGetMultisamplefv(MultisampleParameter.SamplePosition, index, ptr);
            }
        }
    }
}