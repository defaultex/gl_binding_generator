#if (GL_NV_explicit_multisample && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_POSITION_NV = 0x8E50;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_MASK_NV = 0x8E51;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_MASK_VALUE_NV = 0x8E52;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_RENDERBUFFER_NV = 0x8E55;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_RENDERBUFFER_NV = 0x8E56;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SAMPLE_MASK_WORDS_NV = 0x8E59;
#endif
    }
}
#endif