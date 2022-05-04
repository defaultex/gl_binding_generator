#if (GL_IMG_multisampled_render_to_texture && (GLES1_API || GLES2_API))
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDERBUFFER_SAMPLES_IMG = 0x9133;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SAMPLES_IMG = 0x9135;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SAMPLES_IMG = 0x9136;
#endif
    }
}
#endif