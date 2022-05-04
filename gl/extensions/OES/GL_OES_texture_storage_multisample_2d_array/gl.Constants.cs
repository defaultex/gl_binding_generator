#if (GL_OES_texture_storage_multisample_2d_array && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES = 0x9102;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES = 0x9105;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910D;
#endif
    }
}
#endif