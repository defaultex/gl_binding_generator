#if (GL_APPLE_fence && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteFencesAPPLE(GLsizei n, GLuint* fences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteFencesAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFinishFenceAPPLE(GLuint fence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glFinishFenceAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFinishObjectAPPLE(GLenum object, GLint name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectTypeAPPLE, GLint, void> glFinishObjectAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenFencesAPPLE(GLsizei n, GLuint* fences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenFencesAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsFenceAPPLE(GLuint fence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsFenceAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSetFenceAPPLE(GLuint fence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glSetFenceAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glTestFenceAPPLE(GLuint fence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glTestFenceAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glTestObjectAPPLE(GLenum object, GLuint name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectTypeAPPLE, GLuint, GLboolean> glTestObjectAPPLE;
#endif
    }
}
#endif