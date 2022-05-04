#if (GL_ARB_transpose_matrix && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
#endif
    }
}
#endif