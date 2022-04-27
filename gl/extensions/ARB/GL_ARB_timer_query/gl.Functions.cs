#if (GL_ARB_timer_query && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetQueryObjecti64v(GLuint id, GLenum pname, GLint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64v;

        /// <summary>void glGetQueryObjectui64v(GLuint id, GLenum pname, GLuint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64v;

        /// <summary>void glQueryCounter(GLuint id, GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryCounterTarget, void> glQueryCounter;
    }
}
#endif