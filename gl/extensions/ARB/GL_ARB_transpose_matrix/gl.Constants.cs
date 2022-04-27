#if (GL_ARB_transpose_matrix && GL_API)
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
        public const GLenum GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
        public const GLenum GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
        public const GLenum GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
    }
}
#endif