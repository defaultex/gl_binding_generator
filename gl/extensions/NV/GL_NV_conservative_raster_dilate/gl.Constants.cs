#if (GL_NV_conservative_raster_dilate && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSERVATIVE_RASTER_DILATE_NV = 0x9379;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B;
#endif
    }
}
#endif