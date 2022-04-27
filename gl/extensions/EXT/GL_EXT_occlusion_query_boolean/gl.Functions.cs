#if (GL_EXT_occlusion_query_boolean && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBeginQueryEXT(GLenum target, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLquery, void> glBeginQueryEXT;

        /// <summary>void glDeleteQueriesEXT(GLsizei n, const GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glDeleteQueriesEXT;

        /// <summary>void glEndQueryEXT(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQueryEXT;

        /// <summary>void glGenQueriesEXT(GLsizei n, GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glGenQueriesEXT;

        /// <summary>void glGetQueryObjectuivEXT(GLuint id, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuivEXT;

        /// <summary>void glGetQueryivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryivEXT;

        /// <summary>GLboolean glIsQueryEXT(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLboolean> glIsQueryEXT;
    }
}
#endif