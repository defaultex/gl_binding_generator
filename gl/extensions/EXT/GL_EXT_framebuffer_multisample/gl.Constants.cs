#if (GL_EXT_framebuffer_multisample && GL_API)
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
        public const GLenum GL_MAX_SAMPLES_EXT = 0x8D57;
    }
}
#endif