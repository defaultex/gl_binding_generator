#if (GL_APPLE_sync && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>GLenum glClientWaitSyncAPPLE(GLsync sync, GLbitfield flags, GLuint64 timeout)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncObjectMask, GLuint64, GLenum> glClientWaitSyncAPPLE;

        /// <summary>void glDeleteSyncAPPLE(GLsync sync)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, void> glDeleteSyncAPPLE;

        /// <summary>GLsync glFenceSyncAPPLE(GLenum condition, GLbitfield flags)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, GLsync> glFenceSyncAPPLE;

        /// <summary>void glGetInteger64vAPPLE(GLenum pname, GLint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64vAPPLE;

        /// <summary>void glGetSyncivAPPLE(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSyncivAPPLE;

        /// <summary>GLboolean glIsSyncAPPLE(GLsync sync)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, GLboolean> glIsSyncAPPLE;

        /// <summary>void glWaitSyncAPPLE(GLsync sync, GLbitfield flags, GLuint64 timeout)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncBehaviorFlags, GLuint64, void> glWaitSyncAPPLE;
    }
}
#endif