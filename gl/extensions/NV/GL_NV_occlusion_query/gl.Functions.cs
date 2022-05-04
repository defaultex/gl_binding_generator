#if (GL_NV_occlusion_query && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginOcclusionQueryNV(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginOcclusionQueryNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteOcclusionQueriesNV(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteOcclusionQueriesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndOcclusionQueryNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndOcclusionQueryNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenOcclusionQueriesNV(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenOcclusionQueriesNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetOcclusionQueryivNV(GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, OcclusionQueryParameterNameNV, GLint*, void> glGetOcclusionQueryivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetOcclusionQueryuivNV(GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, OcclusionQueryParameterNameNV, GLuint*, void> glGetOcclusionQueryuivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsOcclusionQueryNV(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsOcclusionQueryNV;
#endif
    }
}
#endif