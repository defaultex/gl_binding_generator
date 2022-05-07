#if (GL_AMD_framebuffer_multisample_advanced && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER_STORAGE_SAMPLES_AMD = 0x91B2;
        public const GLenum GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD = 0x91B3;
        public const GLenum GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD = 0x91B4;
        public const GLenum GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD = 0x91B5;
        public const GLenum GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B6;
        public const GLenum GL_SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B7;
    }
}
#endif