#if (GL_AMD_framebuffer_multisample_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDERBUFFER_STORAGE_SAMPLES_AMD = 0x91B2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD = 0x91B3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD = 0x91B4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD = 0x91B5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B7;
#endif
    }
}
#endif