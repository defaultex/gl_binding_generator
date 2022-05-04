#if (GL_ARB_occlusion_query && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginQueryARB(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, query, void> glBeginQueryARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteQueriesARB(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glDeleteQueriesARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndQueryARB(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQueryARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenQueriesARB(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glGenQueriesARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryivARB(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjectivARB(GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLint*, void> glGetQueryObjectivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetQueryObjectuivARB(GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsQueryARB(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, GLboolean> glIsQueryARB;
#endif
    }
}
#endif