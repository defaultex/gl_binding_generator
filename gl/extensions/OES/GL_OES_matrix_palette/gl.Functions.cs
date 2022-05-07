#if (GL_OES_matrix_palette && !gles1)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glCurrentPaletteMatrixOES(GLuint matrixpaletteindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glCurrentPaletteMatrixOES;

        /// <summary>void glLoadPaletteFromModelViewMatrixOES();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLoadPaletteFromModelViewMatrixOES;

        /// <summary>void glMatrixIndexPointerOES(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, MatrixIndexPointerTypeARB, GLsizei, void*, void> glMatrixIndexPointerOES;

        /// <summary>void glWeightPointerOES(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void*, void> glWeightPointerOES;
    }
}
#endif