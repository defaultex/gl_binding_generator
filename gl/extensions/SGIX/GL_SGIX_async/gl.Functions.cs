#if (GL_SGIX_async && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAsyncMarkerSGIX(GLuint marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glAsyncMarkerSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteAsyncMarkersSGIX(GLuint marker, GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, void> glDeleteAsyncMarkersSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glFinishAsyncSGIX(GLuint* markerp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLint> glFinishAsyncSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGenAsyncMarkersSGIX(GLsizei range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint> glGenAsyncMarkersSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsAsyncMarkerSGIX(GLuint marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsAsyncMarkerSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glPollAsyncSGIX(GLuint* markerp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLint> glPollAsyncSGIX;
#endif
    }
}
#endif