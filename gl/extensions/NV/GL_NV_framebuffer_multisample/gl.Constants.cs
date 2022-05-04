#if (GL_NV_framebuffer_multisample && GLES2_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDERBUFFER_SAMPLES_NV = 0x8CAB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV = 0x8D56;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SAMPLES_NV = 0x8D57;
#endif
    }
}
#endif