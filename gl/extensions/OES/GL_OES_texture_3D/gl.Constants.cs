#if (GL_OES_texture_3D && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_3D_OES = 0x806A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_3D_OES = 0x806F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_WRAP_R_OES = 0x8072;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_3D_OES = 0x8B5F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4;
#endif
    }
}
#endif