#if (GL_OES_texture_storage_multisample_2d_array && GLES2_API)
public partial class glext_oes { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES = 0x9102;
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES = 0x9105;
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910B;
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910C;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910D;
    }
}
#endif