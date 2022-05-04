#if (GL_AMD_debug_output && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDebugMessageCallbackAMD(GLDEBUGPROCAMD callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROCAMD, void*, void> glDebugMessageCallbackAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDebugMessageEnableAMD(GLenum category, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageEnableAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDebugMessageInsertAMD(GLenum category, GLenum severity, GLuint id, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, DebugSeverity, GLuint, GLsizei, GLchar*, void> glDebugMessageInsertAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGetDebugMessageLogAMD(GLuint count, GLsizei bufSize, GLenum* categories, GLuint* severities, GLuint* ids, GLsizei* lengths, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLenum*, DebugSeverity*, GLuint*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLogAMD;
#endif
    }
}
#endif