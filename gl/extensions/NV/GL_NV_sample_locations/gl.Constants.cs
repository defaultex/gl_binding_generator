#if (GL_NV_sample_locations && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SAMPLE_LOCATION_NV = 0x8E50;
        public const GLenum GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D;
        public const GLenum GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E;
        public const GLenum GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F;
        public const GLenum GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340;
        public const GLenum GL_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341;
        public const GLenum GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342;
        public const GLenum GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343;
    }
}
#endif