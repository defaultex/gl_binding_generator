#if (GL_ANGLE_framebuffer_multisample && GLES2_API)
public partial class glext_angle { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE = 0x8D56;
        public const GLenum GL_MAX_SAMPLES_ANGLE = 0x8D57;
    }
}
#endif