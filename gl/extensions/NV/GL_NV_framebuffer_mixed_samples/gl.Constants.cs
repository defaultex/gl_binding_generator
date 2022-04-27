#if (GL_NV_framebuffer_mixed_samples && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_COLOR_SAMPLES_NV = 0x8E20;
        public const GLenum GL_RASTER_MULTISAMPLE_EXT = 0x9327;
        public const GLenum GL_RASTER_SAMPLES_EXT = 0x9328;
        public const GLenum GL_MAX_RASTER_SAMPLES_EXT = 0x9329;
        public const GLenum GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;
        public const GLenum GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;
        public const GLenum GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;
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