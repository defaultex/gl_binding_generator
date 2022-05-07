#if (GL_AMD_performance_monitor && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginPerfMonitorAMD(GLuint monitor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginPerfMonitorAMD;

        /// <summary>void glDeletePerfMonitorsAMD(GLsizei n, GLuint* monitors);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeletePerfMonitorsAMD;

        /// <summary>void glEndPerfMonitorAMD(GLuint monitor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndPerfMonitorAMD;

        /// <summary>void glGenPerfMonitorsAMD(GLsizei n, GLuint* monitors);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenPerfMonitorsAMD;

        /// <summary>void glGetPerfMonitorCounterDataAMD(GLuint monitor, GLenum pname, GLsizei dataSize, GLuint* data, GLint* bytesWritten);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLsizei, GLuint*, GLint*, void> glGetPerfMonitorCounterDataAMD;

        /// <summary>void glGetPerfMonitorCounterInfoAMD(GLuint group, GLuint counter, GLenum pname, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, void*, void> glGetPerfMonitorCounterInfoAMD;

        /// <summary>void glGetPerfMonitorCountersAMD(GLuint group, GLint* numCounters, GLint* maxActiveCounters, GLsizei counterSize, GLuint* counters);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, GLint*, GLsizei, GLuint*, void> glGetPerfMonitorCountersAMD;

        /// <summary>void glGetPerfMonitorCounterStringAMD(GLuint group, GLuint counter, GLsizei bufSize, GLsizei* length, GLchar* counterString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetPerfMonitorCounterStringAMD;

        /// <summary>void glGetPerfMonitorGroupsAMD(GLint* numGroups, GLsizei groupsSize, GLuint* groups);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLsizei, GLuint*, void> glGetPerfMonitorGroupsAMD;

        /// <summary>void glGetPerfMonitorGroupStringAMD(GLuint group, GLsizei bufSize, GLsizei* length, GLchar* groupString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei*, GLchar*, void> glGetPerfMonitorGroupStringAMD;

        /// <summary>void glSelectPerfMonitorCountersAMD(GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint* counterList);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLuint, GLint, GLuint*, void> glSelectPerfMonitorCountersAMD;
    }
}
#endif