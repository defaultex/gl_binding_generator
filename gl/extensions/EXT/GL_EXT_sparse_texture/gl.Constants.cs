#if (GL_EXT_sparse_texture && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_2D = 0x0DE1;
        public const GLenum GL_TEXTURE_3D = 0x806F;
        public const GLenum GL_TEXTURE_CUBE_MAP = 0x8513;
        public const GLenum GL_TEXTURE_2D_ARRAY = 0x8C1A;
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_X_EXT = 0x9195;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197;
        public const GLenum GL_MAX_SPARSE_TEXTURE_SIZE_EXT = 0x9198;
        public const GLenum GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT = 0x9199;
        public const GLenum GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT = 0x919A;
        public const GLenum GL_TEXTURE_SPARSE_EXT = 0x91A6;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_INDEX_EXT = 0x91A7;
        public const GLenum GL_NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8;
        public const GLenum GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT = 0x91A9;
        public const GLenum GL_NUM_SPARSE_LEVELS_EXT = 0x91AA;
    }
}
#endif