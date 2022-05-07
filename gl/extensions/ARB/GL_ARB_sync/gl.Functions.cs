#if (GL_ARB_sync && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLenum glClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncObjectMask, GLuint64, SyncStatus> glClientWaitSync;

        /// <summary>void glDeleteSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, void> glDeleteSync;

        /// <summary>GLsync glFenceSync(GLenum condition, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, GLsync> glFenceSync;

        /// <summary>void glGetInteger64v(GLenum pname, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64v;

        /// <summary>void glGetSynciv(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSynciv;

        /// <summary>GLboolean glIsSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, GLboolean> glIsSync;

        /// <summary>void glWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncBehaviorFlags, GLuint64, void> glWaitSync;
    }
}
#endif