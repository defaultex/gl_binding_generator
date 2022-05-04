#if (GL_ARB_sparse_buffer && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPARSE_STORAGE_BIT_ARB = 0x0400;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;
#endif
    }
}
#endif