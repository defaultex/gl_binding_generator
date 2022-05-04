#if (GL_EXT_occlusion_query_boolean && GLES2_API)
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
        /// <summary>void glGetQueryivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjectuivEXT(GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsQueryEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, GLboolean> glIsQueryEXT;
#endif
    }
}
#endif