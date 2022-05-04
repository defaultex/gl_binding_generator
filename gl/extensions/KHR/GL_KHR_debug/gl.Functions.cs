#if (GL_KHR_debug && (GL_API || GLCORE_API || GLES1_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDebugMessageCallback(GLDEBUGPROC callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROC, void*, void> glDebugMessageCallback;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDebugMessageCallbackKHR(GLDEBUGPROCKHR callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROCKHR, void*, void> glDebugMessageCallbackKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDebugMessageControl(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControl;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDebugMessageControlKHR(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControlKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDebugMessageInsert(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsert;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDebugMessageInsertKHR(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsertKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetDebugMessageLog(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLog;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGetDebugMessageLogKHR(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLogKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetObjectLabel(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabel;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectLabelKHR(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabelKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetObjectPtrLabel(void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabel;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectPtrLabelKHR(void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabelKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPointervKHR(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void**, void> glGetPointervKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glObjectLabel(GLenum identifier, GLuint name, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabel;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glObjectLabelKHR(GLenum identifier, GLuint name, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabelKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glObjectPtrLabel(void* ptr, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabel;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glObjectPtrLabelKHR(void* ptr, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabelKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glPopDebugGroup();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroup;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPopDebugGroupKHR();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroupKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glPushDebugGroup(GLenum source, GLuint id, GLsizei length, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroup;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPushDebugGroupKHR(GLenum source, GLuint id, GLsizei length, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroupKHR;
#endif
    }
}
#endif