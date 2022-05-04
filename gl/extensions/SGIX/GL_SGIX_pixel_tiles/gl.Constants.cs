#if (GL_SGIX_pixel_tiles && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_WIDTH_SGIX = 0x8140;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145;
#endif
    }
}
#endif