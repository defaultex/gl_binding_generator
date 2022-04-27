#if (GL_NV_blend_minmax_factor && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_FACTOR_MIN_AMD = 0x901C;
        public const GLenum GL_FACTOR_MAX_AMD = 0x901D;
    }
}
#endif