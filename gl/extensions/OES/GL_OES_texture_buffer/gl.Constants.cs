#if (GL_OES_texture_buffer && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_BINDING_OES = 0x8C2A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_OES = 0x8C2A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TEXTURE_BUFFER_SIZE_OES = 0x8C2B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_BUFFER_OES = 0x8C2C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES = 0x8C2D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_BUFFER_OES = 0x8DC2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_SAMPLER_BUFFER_OES = 0x8DD0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_BUFFER_OES = 0x8DD8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BUFFER_OES = 0x9051;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_BUFFER_OES = 0x905C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_BUFFER_OES = 0x9067;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_OES = 0x919D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_SIZE_OES = 0x919E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES = 0x919F;
#endif
    }
}
#endif