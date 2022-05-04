#if (GL_MESA_tile_raster_order && GL_API)
public partial class mesa { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TILE_RASTER_ORDER_FIXED_MESA = 0x8BB8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TILE_RASTER_ORDER_INCREASING_X_MESA = 0x8BB9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TILE_RASTER_ORDER_INCREASING_Y_MESA = 0x8BBA;
#endif
    }
}
#endif