#if (GL_NV_alpha_to_coverage_dither_control && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF;
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D;
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E;
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F;
    }
}
#endif