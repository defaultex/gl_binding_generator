#if (GL_OES_viewport_array && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDepthRangeArrayfvOES(GLuint first, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glDepthRangeArrayfvOES;

        /// <summary>void glDepthRangeIndexedfOES(GLuint index, GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glDepthRangeIndexedfOES;

        /// <summary>void glDisableiOES(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiOES;

        /// <summary>void glEnableiOES(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiOES;

        /// <summary>void glGetFloati_vOES(GLenum target, GLuint index, GLfloat* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_vOES;

        /// <summary>GLboolean glIsEnablediOES(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediOES;

        /// <summary>void glScissorArrayvOES(GLuint first, GLsizei count, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayvOES;

        /// <summary>void glScissorIndexedOES(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexedOES;

        /// <summary>void glScissorIndexedvOES(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedvOES;

        /// <summary>void glViewportArrayvOES(GLuint first, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayvOES;

        /// <summary>void glViewportIndexedfOES(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedfOES;

        /// <summary>void glViewportIndexedfvOES(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfvOES;
    }
}
#endif