#if (GL_NV_fence && (GL_API || GLES1_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteFencesNV(GLsizei n, GLuint* fences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteFencesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFinishFenceNV(GLuint fence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glFinishFenceNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenFencesNV(GLsizei n, GLuint* fences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenFencesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFenceivNV(GLuint fence, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, FenceParameterNameNV, GLint*, void> glGetFenceivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsFenceNV(GLuint fence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsFenceNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSetFenceNV(GLuint fence, GLenum condition);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, FenceConditionNV, void> glSetFenceNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glTestFenceNV(GLuint fence);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glTestFenceNV;
#endif
    }
}
#endif