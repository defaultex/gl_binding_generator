#if (GL_KHR_no_error && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_khr { 
    public partial class Constants { 
        public const GLenum GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008;
    }
}
#endif