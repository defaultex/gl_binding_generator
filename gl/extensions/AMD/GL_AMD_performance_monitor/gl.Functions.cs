#if (GL_AMD_performance_monitor && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginPerfMonitorAMD(GLuint monitor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginPerfMonitorAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeletePerfMonitorsAMD(GLsizei n, GLuint* monitors);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeletePerfMonitorsAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndPerfMonitorAMD(GLuint monitor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndPerfMonitorAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenPerfMonitorsAMD(GLsizei n, GLuint* monitors);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenPerfMonitorsAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfMonitorCounterDataAMD(GLuint monitor, GLenum pname, GLsizei dataSize, GLuint* data, GLint* bytesWritten);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLsizei, GLuint*, GLint*, void> glGetPerfMonitorCounterDataAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfMonitorCounterInfoAMD(GLuint group, GLuint counter, GLenum pname, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, void*, void> glGetPerfMonitorCounterInfoAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfMonitorCountersAMD(GLuint group, GLint* numCounters, GLint* maxActiveCounters, GLsizei counterSize, GLuint* counters);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, GLint*, GLsizei, GLuint*, void> glGetPerfMonitorCountersAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfMonitorCounterStringAMD(GLuint group, GLuint counter, GLsizei bufSize, GLsizei* length, GLchar* counterString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetPerfMonitorCounterStringAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfMonitorGroupsAMD(GLint* numGroups, GLsizei groupsSize, GLuint* groups);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLsizei, GLuint*, void> glGetPerfMonitorGroupsAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfMonitorGroupStringAMD(GLuint group, GLsizei bufSize, GLsizei* length, GLchar* groupString);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsizei*, GLchar*, void> glGetPerfMonitorGroupStringAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSelectPerfMonitorCountersAMD(GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint* counterList);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLuint, GLint, GLuint*, void> glSelectPerfMonitorCountersAMD;
#endif
    }
}
#endif