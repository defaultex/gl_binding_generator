#if (GL_SGIX_list_priority && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetListParameterfvSGIX(GLuint list, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLfloat*, void> glGetListParameterfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetListParameterivSGIX(GLuint list, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLint*, void> glGetListParameterivSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glListParameterfSGIX(GLuint list, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLfloat, void> glListParameterfSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glListParameterfvSGIX(GLuint list, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLfloat*, void> glListParameterfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glListParameteriSGIX(GLuint list, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLint, void> glListParameteriSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glListParameterivSGIX(GLuint list, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLint*, void> glListParameterivSGIX;
#endif
    }
}
#endif