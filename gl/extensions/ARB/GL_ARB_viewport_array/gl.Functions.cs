#if (GL_ARB_viewport_array && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDepthRangeArraydvNV(GLuint first, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glDepthRangeArraydvNV;

        /// <summary>void glDepthRangeArrayv(GLuint first, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glDepthRangeArrayv;

        /// <summary>void glDepthRangeIndexed(GLuint index, GLdouble n, GLdouble f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glDepthRangeIndexed;

        /// <summary>void glDepthRangeIndexeddNV(GLuint index, GLdouble n, GLdouble f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glDepthRangeIndexeddNV;

        /// <summary>void glGetDoublei_v(GLenum target, GLuint index, GLdouble* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLdouble*, void> glGetDoublei_v;

        /// <summary>void glGetFloati_v(GLenum target, GLuint index, GLfloat* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_v;

        /// <summary>void glScissorArrayv(GLuint first, GLsizei count, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayv;

        /// <summary>void glScissorIndexed(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexed;

        /// <summary>void glScissorIndexedv(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedv;

        /// <summary>void glViewportArrayv(GLuint first, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayv;

        /// <summary>void glViewportIndexedf(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedf;

        /// <summary>void glViewportIndexedfv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfv;
    }
}
#endif