#if (GL_NV_framebuffer_multisample && GLES2_API)
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER_SAMPLES_NV = 0x8CAB;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV = 0x8D56;
        public const GLenum GL_MAX_SAMPLES_NV = 0x8D57;
    }
}
#endif