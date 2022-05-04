#if (GL_EXT_sparse_texture && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D = 0x0DE1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_3D = 0x806F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_CUBE_MAP = 0x8513;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_ARRAY = 0x8C1A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIRTUAL_PAGE_SIZE_X_EXT = 0x9195;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SPARSE_TEXTURE_SIZE_EXT = 0x9198;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT = 0x9199;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT = 0x919A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_SPARSE_EXT = 0x91A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIRTUAL_PAGE_SIZE_INDEX_EXT = 0x91A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT = 0x91A9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NUM_SPARSE_LEVELS_EXT = 0x91AA;
#endif
    }
}
#endif