#if (GL_NV_fence && (GL_API || GLES1_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDeleteFencesNV(GLsizei n, const GLuint* fences)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteFencesNV;

        /// <summary>void glFinishFenceNV(GLuint fence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glFinishFenceNV;

        /// <summary>void glGenFencesNV(GLsizei n, GLuint* fences)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenFencesNV;

        /// <summary>void glGetFenceivNV(GLuint fence, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, FenceParameterNameNV, GLint*, void> glGetFenceivNV;

        /// <summary>GLboolean glIsFenceNV(GLuint fence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsFenceNV;

        /// <summary>void glSetFenceNV(GLuint fence, GLenum condition)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, FenceConditionNV, void> glSetFenceNV;

        /// <summary>GLboolean glTestFenceNV(GLuint fence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glTestFenceNV;
    }
}
#endif