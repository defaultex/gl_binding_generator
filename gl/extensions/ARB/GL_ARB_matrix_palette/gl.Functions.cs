#if (GL_ARB_matrix_palette && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCurrentPaletteMatrixARB(GLint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glCurrentPaletteMatrixARB;

        /// <summary>void glMatrixIndexPointerARB(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, MatrixIndexPointerTypeARB, GLsizei, void*, void> glMatrixIndexPointerARB;

        /// <summary>void glMatrixIndexubvARB(GLint size, GLubyte* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLubyte*, void> glMatrixIndexubvARB;

        /// <summary>void glMatrixIndexuivARB(GLint size, GLuint* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint*, void> glMatrixIndexuivARB;

        /// <summary>void glMatrixIndexusvARB(GLint size, GLushort* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLushort*, void> glMatrixIndexusvARB;
    }
}
#endif