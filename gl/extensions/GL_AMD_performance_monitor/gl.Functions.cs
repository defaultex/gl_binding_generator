#if GL_AMD_performance_monitor

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginPerfMonitorAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeletePerfMonitorsAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndPerfMonitorAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenPerfMonitorsAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLsizei, GLuint*, GLint*, void> glGetPerfMonitorCounterDataAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, void*, void> glGetPerfMonitorCounterInfoAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, GLint*, GLsizei, GLuint*, void> glGetPerfMonitorCountersAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetPerfMonitorCounterStringAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLsizei, GLuint*, void> glGetPerfMonitorGroupsAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei*, GLchar*, void> glGetPerfMonitorGroupStringAMD;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLuint, GLint, GLuint*, void> glSelectPerfMonitorCountersAMD;
    }
}

#endif