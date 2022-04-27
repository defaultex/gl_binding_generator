#if (GL_ARB_sparse_buffer && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_SPARSE_STORAGE_BIT_ARB = 0x0400;
        public const GLenum GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;
    }
}
#endif