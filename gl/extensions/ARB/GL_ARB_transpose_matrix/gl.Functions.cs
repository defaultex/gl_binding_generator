#if (GL_ARB_transpose_matrix && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glLoadTransposeMatrixdARB(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glLoadTransposeMatrixdARB;

        /// <summary>void glLoadTransposeMatrixfARB(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadTransposeMatrixfARB;

        /// <summary>void glMultTransposeMatrixdARB(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glMultTransposeMatrixdARB;

        /// <summary>void glMultTransposeMatrixfARB(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultTransposeMatrixfARB;
    }
}
#endif