#if (GL_MESA_tile_raster_order && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TILE_RASTER_ORDER_FIXED_MESA = 0x8BB8;
        public const GLenum GL_TILE_RASTER_ORDER_INCREASING_X_MESA = 0x8BB9;
        public const GLenum GL_TILE_RASTER_ORDER_INCREASING_Y_MESA = 0x8BBA;
    }
}
#endif