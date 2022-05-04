#if (GL_NV_framebuffer_mixed_samples && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_SAMPLES_NV = 0x8E20;
#endif

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

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_SAMPLES_NV = 0x932D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_SAMPLES_NV = 0x932E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_MODULATION_TABLE_NV = 0x9331;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_MODULATION_NV = 0x9332;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;
#endif
    }
}
#endif