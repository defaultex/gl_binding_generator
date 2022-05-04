#if (GL_ARB_sync && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLenum glClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncObjectMask, GLuint64, SyncStatus> glClientWaitSync;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDeleteSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, void> glDeleteSync;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLsync glFenceSync(GLenum condition, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, sync> glFenceSync;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetInteger64v(GLenum pname, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetSynciv(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSynciv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, GLboolean> glIsSync;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncBehaviorFlags, GLuint64, void> glWaitSync;
#endif
    }
}
#endif