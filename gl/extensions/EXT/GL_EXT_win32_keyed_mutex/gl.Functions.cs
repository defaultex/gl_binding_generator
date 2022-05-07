#if (GL_EXT_win32_keyed_mutex && (!gl || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLboolean glAcquireKeyedMutexWin32EXT(GLuint memory, GLuint64 key, GLuint timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, GLuint, GLboolean> glAcquireKeyedMutexWin32EXT;

        /// <summary>GLboolean glReleaseKeyedMutexWin32EXT(GLuint memory, GLuint64 key);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, GLboolean> glReleaseKeyedMutexWin32EXT;
    }
}
#endif