#if (GL_NV_internalformat_sample_query && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER = 0x8D41;
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const GLenum GL_MULTISAMPLES_NV = 0x9371;
        public const GLenum GL_SUPERSAMPLE_SCALE_X_NV = 0x9372;
        public const GLenum GL_SUPERSAMPLE_SCALE_Y_NV = 0x9373;
        public const GLenum GL_CONFORMANT_NV = 0x9374;
    }
}
#endif