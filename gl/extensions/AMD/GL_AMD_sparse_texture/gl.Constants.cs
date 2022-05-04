#if (GL_AMD_sparse_texture && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIRTUAL_PAGE_SIZE_X_AMD = 0x9195;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_SPARSE_LEVEL_AMD = 0x919B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_LOD_WARNING_AMD = 0x919C;
#endif
    }
}
#endif