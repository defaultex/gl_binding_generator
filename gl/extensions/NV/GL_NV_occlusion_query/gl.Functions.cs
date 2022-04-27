#if (GL_NV_occlusion_query && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginOcclusionQueryNV(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginOcclusionQueryNV;

        /// <summary>void glDeleteOcclusionQueriesNV(GLsizei n, const GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteOcclusionQueriesNV;

        /// <summary>void glEndOcclusionQueryNV()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndOcclusionQueryNV;

        /// <summary>void glGenOcclusionQueriesNV(GLsizei n, GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenOcclusionQueriesNV;

        /// <summary>void glGetOcclusionQueryivNV(GLuint id, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, OcclusionQueryParameterNameNV, GLint*, void> glGetOcclusionQueryivNV;

        /// <summary>void glGetOcclusionQueryuivNV(GLuint id, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, OcclusionQueryParameterNameNV, GLuint*, void> glGetOcclusionQueryuivNV;

        /// <summary>GLboolean glIsOcclusionQueryNV(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsOcclusionQueryNV;
    }
}
#endif