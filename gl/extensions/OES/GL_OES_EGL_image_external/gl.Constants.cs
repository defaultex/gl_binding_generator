#if (GL_OES_EGL_image_external && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_EXTERNAL_OES = 0x8D65;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_EXTERNAL_OES = 0x8D66;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BINDING_EXTERNAL_OES = 0x8D67;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68;
#endif
    }
}
#endif