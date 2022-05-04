#if (GL_APPLE_vertex_program_evaluators && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableVertexAttribAPPLE(GLuint index, GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glDisableVertexAttribAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableVertexAttribAPPLE(GLuint index, GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glEnableVertexAttribAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsVertexAttribEnabledAPPLE(GLuint index, GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLboolean> glIsVertexAttribEnabledAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapVertexAttrib1dAPPLE(GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLdouble, GLdouble, GLint, GLint, GLdouble*, void> glMapVertexAttrib1dAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapVertexAttrib1fAPPLE(GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLfloat, GLfloat, GLint, GLint, GLfloat*, void> glMapVertexAttrib1fAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapVertexAttrib2dAPPLE(GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLdouble, GLdouble, GLint, GLint, GLdouble, GLdouble, GLint, GLint, GLdouble*, void> glMapVertexAttrib2dAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapVertexAttrib2fAPPLE(GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLfloat, GLfloat, GLint, GLint, GLfloat, GLfloat, GLint, GLint, GLfloat*, void> glMapVertexAttrib2fAPPLE;
#endif
    }
}
#endif