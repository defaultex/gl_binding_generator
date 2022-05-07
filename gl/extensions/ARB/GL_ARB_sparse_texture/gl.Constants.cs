#if (GL_ARB_sparse_texture && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;
        public const GLenum GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;
        public const GLenum GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;
        public const GLenum GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A;
        public const GLenum GL_TEXTURE_SPARSE_ARB = 0x91A6;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;
        public const GLenum GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;
        public const GLenum GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;
        public const GLenum GL_NUM_SPARSE_LEVELS_ARB = 0x91AA;
    }
}
#endif