#if (GL_OES_draw_texture && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glDrawTexfOES(GLfloat x, GLfloat y, GLfloat z, GLfloat width, GLfloat height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glDrawTexfOES;

        /// <summary>void glDrawTexfvOES(const GLfloat* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glDrawTexfvOES;

        /// <summary>void glDrawTexiOES(GLint x, GLint y, GLint z, GLint width, GLint height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glDrawTexiOES;

        /// <summary>void glDrawTexivOES(const GLint* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glDrawTexivOES;

        /// <summary>void glDrawTexsOES(GLshort x, GLshort y, GLshort z, GLshort width, GLshort height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, GLshort, void> glDrawTexsOES;

        /// <summary>void glDrawTexsvOES(const GLshort* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glDrawTexsvOES;

        /// <summary>void glDrawTexxOES(GLfixed x, GLfixed y, GLfixed z, GLfixed width, GLfixed height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glDrawTexxOES;

        /// <summary>void glDrawTexxvOES(const GLfixed* coords)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glDrawTexxvOES;
    }
}
#endif