#if (GL_EXT_raster_multisample && (GL_API || GLCORE_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RASTER_MULTISAMPLE_EXT = 0x9327;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RASTER_SAMPLES_EXT = 0x9328;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_RASTER_SAMPLES_EXT = 0x9329;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;
#endif
    }
}
#endif