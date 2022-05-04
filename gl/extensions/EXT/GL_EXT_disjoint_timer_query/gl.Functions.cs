#if (GL_EXT_disjoint_timer_query && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginQueryEXT(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, query, void> glBeginQueryEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteQueriesEXT(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glDeleteQueriesEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndQueryEXT(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQueryEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenQueriesEXT(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glGenQueriesEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetInteger64vEXT(GLenum pname, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjecti64vEXT(GLuint id, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjectivEXT(GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLint*, void> glGetQueryObjectivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjectui64vEXT(GLuint id, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjectuivEXT(GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsQueryEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, GLboolean> glIsQueryEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glQueryCounterEXT(GLuint id, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryCounterTarget, void> glQueryCounterEXT;
#endif
    }
}
#endif