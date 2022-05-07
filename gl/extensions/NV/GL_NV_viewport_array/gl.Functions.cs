#if (GL_NV_viewport_array && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDepthRangeArrayfvNV(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glDepthRangeArrayfvNV;

        /// <summary>void glDepthRangeIndexedfNV(GLuint index, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glDepthRangeIndexedfNV;

        /// <summary>void glDisableiNV(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiNV;

        /// <summary>void glEnableiNV(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiNV;

        /// <summary>void glGetFloati_vNV(GLenum target, GLuint index, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_vNV;

        /// <summary>GLboolean glIsEnablediNV(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediNV;

        /// <summary>void glScissorArrayvNV(GLuint first, GLsizei count, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayvNV;

        /// <summary>void glScissorIndexedNV(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexedNV;

        /// <summary>void glScissorIndexedvNV(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedvNV;

        /// <summary>void glViewportArrayvNV(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayvNV;

        /// <summary>void glViewportIndexedfNV(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedfNV;

        /// <summary>void glViewportIndexedfvNV(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfvNV;
    }
}
#endif