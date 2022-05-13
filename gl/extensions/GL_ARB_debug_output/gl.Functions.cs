#if GL_ARB_debug_output

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROCARB, void*, void> glDebugMessageCallbackARB;
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControlARB;
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsertARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLogARB;
    }
}

#endif