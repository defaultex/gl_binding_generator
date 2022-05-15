#if GL_ARB_debug_output

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glDebugMessageCallbackARB(GLDEBUGPROCARB callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROCARB, void*, void> glDebugMessageCallbackARB;

        /// <summary>void glDebugMessageControlARB(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControlARB;

        /// <summary>void glDebugMessageInsertARB(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsertARB;

        /// <summary>GLuint glGetDebugMessageLogARB(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLogARB;
    }
}

#endif