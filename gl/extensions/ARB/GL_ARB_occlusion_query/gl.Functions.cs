#if (GL_ARB_occlusion_query && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginQueryARB(GLenum target, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLquery, void> glBeginQueryARB;

        /// <summary>void glDeleteQueriesARB(GLsizei n, const GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glDeleteQueriesARB;

        /// <summary>void glEndQueryARB(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQueryARB;

        /// <summary>void glGenQueriesARB(GLsizei n, GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glGenQueriesARB;

        /// <summary>void glGetQueryObjectivARB(GLuint id, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLint*, void> glGetQueryObjectivARB;

        /// <summary>void glGetQueryObjectuivARB(GLuint id, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuivARB;

        /// <summary>void glGetQueryivARB(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryivARB;

        /// <summary>GLboolean glIsQueryARB(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLboolean> glIsQueryARB;
    }
}
#endif