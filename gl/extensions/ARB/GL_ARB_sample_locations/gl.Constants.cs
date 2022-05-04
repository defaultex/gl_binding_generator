#if (GL_ARB_sample_locations && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_LOCATION_ARB = 0x8E50;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;
#endif
    }
}
#endif