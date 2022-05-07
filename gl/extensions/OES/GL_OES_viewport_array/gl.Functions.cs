#if (GL_OES_viewport_array && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDepthRangeArrayfvOES(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glDepthRangeArrayfvOES;

        /// <summary>void glDepthRangeIndexedfOES(GLuint index, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glDepthRangeIndexedfOES;

        /// <summary>void glGetFloati_vOES(GLenum target, GLuint index, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_vOES;

        /// <summary>void glScissorArrayvOES(GLuint first, GLsizei count, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayvOES;

        /// <summary>void glScissorIndexedOES(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexedOES;

        /// <summary>void glScissorIndexedvOES(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedvOES;

        /// <summary>void glViewportArrayvOES(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayvOES;

        /// <summary>void glViewportIndexedfOES(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedfOES;

        /// <summary>void glViewportIndexedfvOES(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfvOES;
    }
}
#endif