#if (GL_ARB_transpose_matrix && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glLoadTransposeMatrixdARB(const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glLoadTransposeMatrixdARB;

        /// <summary>void glLoadTransposeMatrixfARB(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadTransposeMatrixfARB;

        /// <summary>void glMultTransposeMatrixdARB(const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glMultTransposeMatrixdARB;

        /// <summary>void glMultTransposeMatrixfARB(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultTransposeMatrixfARB;
    }
}
#endif