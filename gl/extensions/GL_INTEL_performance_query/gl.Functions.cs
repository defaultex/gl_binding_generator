#if GL_INTEL_performance_query

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginPerfQueryINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glCreatePerfQueryINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDeletePerfQueryINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndPerfQueryINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glGetFirstPerfQueryIdINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glGetNextPerfQueryIdINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLchar*, GLuint, GLchar*, GLuint*, GLuint*, GLuint*, GLuint*, GLuint64*, void> glGetPerfCounterInfoINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, void*, GLuint*, void> glGetPerfQueryDataINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLchar*, GLuint*, void> glGetPerfQueryIdByNameINTEL;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLchar*, GLuint*, GLuint*, GLuint*, GLuint*, void> glGetPerfQueryInfoINTEL;
    }
}

#endif