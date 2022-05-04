#if (GL_EXT_win32_keyed_mutex && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glAcquireKeyedMutexWin32EXT(GLuint memory, GLuint64 key, GLuint timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, GLuint, GLboolean> glAcquireKeyedMutexWin32EXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glReleaseKeyedMutexWin32EXT(GLuint memory, GLuint64 key);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, GLboolean> glReleaseKeyedMutexWin32EXT;
#endif
    }
}
#endif