#if (GL_ARB_transpose_matrix && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
        public const GLenum GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
        public const GLenum GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
        public const GLenum GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
    }
}
#endif