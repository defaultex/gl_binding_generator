#if (GL_APPLE_fence && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDeleteFencesAPPLE(GLsizei n, const GLuint* fences)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteFencesAPPLE;

        /// <summary>void glFinishFenceAPPLE(GLuint fence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glFinishFenceAPPLE;

        /// <summary>void glFinishObjectAPPLE(GLenum object, GLint name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectTypeAPPLE, GLint, void> glFinishObjectAPPLE;

        /// <summary>void glGenFencesAPPLE(GLsizei n, GLuint* fences)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenFencesAPPLE;

        /// <summary>GLboolean glIsFenceAPPLE(GLuint fence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsFenceAPPLE;

        /// <summary>void glSetFenceAPPLE(GLuint fence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glSetFenceAPPLE;

        /// <summary>GLboolean glTestFenceAPPLE(GLuint fence)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glTestFenceAPPLE;

        /// <summary>GLboolean glTestObjectAPPLE(GLenum object, GLuint name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectTypeAPPLE, GLuint, GLboolean> glTestObjectAPPLE;
    }
}
#endif