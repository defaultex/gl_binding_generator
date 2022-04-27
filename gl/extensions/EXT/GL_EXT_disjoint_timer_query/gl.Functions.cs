#if (GL_EXT_disjoint_timer_query && GLES2_API)
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

        /// <summary>void glGetInteger64vEXT(GLenum pname, GLint64* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64vEXT;

        /// <summary>void glGetQueryObjecti64vEXT(GLuint id, GLenum pname, GLint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64vEXT;

        /// <summary>void glGetQueryObjectivEXT(GLuint id, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLint*, void> glGetQueryObjectivEXT;

        /// <summary>void glGetQueryObjectui64vEXT(GLuint id, GLenum pname, GLuint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64vEXT;

        /// <summary>void glGetQueryObjectuivEXT(GLuint id, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuivEXT;

        /// <summary>void glGetQueryivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryivEXT;

        /// <summary>GLboolean glIsQueryEXT(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLboolean> glIsQueryEXT;

        /// <summary>void glQueryCounterEXT(GLuint id, GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryCounterTarget, void> glQueryCounterEXT;
    }
}
#endif