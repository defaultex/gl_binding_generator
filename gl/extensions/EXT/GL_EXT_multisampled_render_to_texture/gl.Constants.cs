#if (GL_EXT_multisampled_render_to_texture && (GLES1_API || GLES2_API))
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
        public const GLenum GL_MAX_SAMPLES_EXT = 0x8D57;
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;
    }
}
#endif