#if (GL_KHR_debug && (!gl || !glcore || !gles1 || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDebugMessageCallback(GLDEBUGPROC callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROC, void*, void> glDebugMessageCallback;

        /// <summary>void glDebugMessageCallbackKHR(GLDEBUGPROCKHR callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROCKHR, void*, void> glDebugMessageCallbackKHR;

        /// <summary>void glDebugMessageControl(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControl;

        /// <summary>void glDebugMessageControlKHR(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControlKHR;

        /// <summary>void glDebugMessageInsert(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsert;

        /// <summary>void glDebugMessageInsertKHR(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsertKHR;

        /// <summary>GLuint glGetDebugMessageLog(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLog;

        /// <summary>GLuint glGetDebugMessageLogKHR(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLogKHR;

        /// <summary>void glGetObjectLabel(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabel;

        /// <summary>void glGetObjectLabelKHR(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabelKHR;

        /// <summary>void glGetObjectPtrLabel(void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabel;

        /// <summary>void glGetObjectPtrLabelKHR(void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabelKHR;

        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;

        /// <summary>void glGetPointervKHR(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void**, void> glGetPointervKHR;

        /// <summary>void glObjectLabel(GLenum identifier, GLuint name, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabel;

        /// <summary>void glObjectLabelKHR(GLenum identifier, GLuint name, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabelKHR;

        /// <summary>void glObjectPtrLabel(void* ptr, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabel;

        /// <summary>void glObjectPtrLabelKHR(void* ptr, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabelKHR;

        /// <summary>void glPopDebugGroup();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroup;

        /// <summary>void glPopDebugGroupKHR();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroupKHR;

        /// <summary>void glPushDebugGroup(GLenum source, GLuint id, GLsizei length, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroup;

        /// <summary>void glPushDebugGroupKHR(GLenum source, GLuint id, GLsizei length, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroupKHR;
    }
}
#endif