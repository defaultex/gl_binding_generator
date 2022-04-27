#if (GL_NV_framebuffer_multisample_coverage && (GL_API || GLCORE_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;
        public const GLenum GL_RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;
        public const GLenum GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;
        public const GLenum GL_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;
    }
}
#endif