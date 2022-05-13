#if GL_NV_framebuffer_mixed_samples

public partial class gl { 
    public partial class Constants {
        public const GLenum GL_COLOR_SAMPLES_NV = 0x8E20;
        public const GLenum GL_DEPTH_SAMPLES_NV = 0x932D;
        public const GLenum GL_STENCIL_SAMPLES_NV = 0x932E;
        public const GLenum GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;
        public const GLenum GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;
        public const GLenum GL_COVERAGE_MODULATION_TABLE_NV = 0x9331;
        public const GLenum GL_COVERAGE_MODULATION_NV = 0x9332;
        public const GLenum GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;
    }
}

#endif