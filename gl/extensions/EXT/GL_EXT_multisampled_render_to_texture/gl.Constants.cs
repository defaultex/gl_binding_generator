#if (GL_EXT_multisampled_render_to_texture && (GLES1_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SAMPLES_EXT = 0x8D57;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;
#endif
    }
}
#endif