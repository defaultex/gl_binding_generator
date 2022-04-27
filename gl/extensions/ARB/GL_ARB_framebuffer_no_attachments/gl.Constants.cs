#if (GL_ARB_framebuffer_no_attachments && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
        public const GLenum GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
        public const GLenum GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
        public const GLenum GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
        public const GLenum GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
        public const GLenum GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
        public const GLenum GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
        public const GLenum GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
        public const GLenum GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
    }
}
#endif