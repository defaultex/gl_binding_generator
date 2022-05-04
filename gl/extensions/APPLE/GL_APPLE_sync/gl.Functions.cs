#if (GL_APPLE_sync && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glClientWaitSyncAPPLE(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncObjectMask, GLuint64, SyncStatus> glClientWaitSyncAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteSyncAPPLE(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, void> glDeleteSyncAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLsync glFenceSyncAPPLE(GLenum condition, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, sync> glFenceSyncAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetInteger64vAPPLE(GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64vAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSyncivAPPLE(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSyncivAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsSyncAPPLE(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, GLboolean> glIsSyncAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWaitSyncAPPLE(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncBehaviorFlags, GLuint64, void> glWaitSyncAPPLE;
#endif
    }
}
#endif