#if (GL_SGIX_pixel_tiles && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E;
        public const GLenum GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F;
        public const GLenum GL_PIXEL_TILE_WIDTH_SGIX = 0x8140;
        public const GLenum GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141;
        public const GLenum GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142;
        public const GLenum GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143;
        public const GLenum GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144;
        public const GLenum GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145;
    }
}
#endif