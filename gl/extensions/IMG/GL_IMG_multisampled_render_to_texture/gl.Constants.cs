#if (GL_IMG_multisampled_render_to_texture && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER_SAMPLES_IMG = 0x9133;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134;
        public const GLenum GL_MAX_SAMPLES_IMG = 0x9135;
        public const GLenum GL_TEXTURE_SAMPLES_IMG = 0x9136;
    }
}
#endif