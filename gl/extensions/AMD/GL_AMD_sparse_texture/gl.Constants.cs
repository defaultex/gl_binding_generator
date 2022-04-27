#if (GL_AMD_sparse_texture && GL_API)
public partial class glext_amd { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_X_AMD = 0x9195;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196;
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197;
        public const GLenum GL_MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198;
        public const GLenum GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199;
        public const GLenum GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A;
        public const GLenum GL_MIN_SPARSE_LEVEL_AMD = 0x919B;
        public const GLenum GL_MIN_LOD_WARNING_AMD = 0x919C;
    }
}
#endif