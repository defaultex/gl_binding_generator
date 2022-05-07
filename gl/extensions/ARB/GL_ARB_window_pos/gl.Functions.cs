#if (GL_ARB_window_pos && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glWindowPos2dARB(GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glWindowPos2dARB;

        /// <summary>void glWindowPos2dvARB(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos2dvARB;

        /// <summary>void glWindowPos2fARB(GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glWindowPos2fARB;

        /// <summary>void glWindowPos2fvARB(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos2fvARB;

        /// <summary>void glWindowPos2iARB(GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glWindowPos2iARB;

        /// <summary>void glWindowPos2ivARB(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos2ivARB;

        /// <summary>void glWindowPos2sARB(GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glWindowPos2sARB;

        /// <summary>void glWindowPos2svARB(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos2svARB;

        /// <summary>void glWindowPos3dARB(GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glWindowPos3dARB;

        /// <summary>void glWindowPos3dvARB(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos3dvARB;

        /// <summary>void glWindowPos3fARB(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glWindowPos3fARB;

        /// <summary>void glWindowPos3fvARB(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos3fvARB;

        /// <summary>void glWindowPos3iARB(GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glWindowPos3iARB;

        /// <summary>void glWindowPos3ivARB(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos3ivARB;

        /// <summary>void glWindowPos3sARB(GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glWindowPos3sARB;

        /// <summary>void glWindowPos3svARB(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos3svARB;
    }
}
#endif