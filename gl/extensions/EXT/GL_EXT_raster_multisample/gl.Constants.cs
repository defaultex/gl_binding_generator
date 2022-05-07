#if (GL_EXT_raster_multisample && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RASTER_MULTISAMPLE_EXT = 0x9327;
        public const GLenum GL_RASTER_SAMPLES_EXT = 0x9328;
        public const GLenum GL_MAX_RASTER_SAMPLES_EXT = 0x9329;
        public const GLenum GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;
        public const GLenum GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;
        public const GLenum GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;
    }
}
#endif