#if (GL_ARB_matrix_palette && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MATRIX_PALETTE_ARB = 0x8840;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PALETTE_MATRICES_ARB = 0x8842;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MATRIX_INDEX_ARRAY_ARB = 0x8844;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_MATRIX_INDEX_ARB = 0x8845;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;
#endif
    }
}
#endif