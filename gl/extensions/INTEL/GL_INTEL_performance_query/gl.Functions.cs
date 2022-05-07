#if (GL_INTEL_performance_query && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginPerfQueryINTEL(GLuint queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginPerfQueryINTEL;

        /// <summary>void glCreatePerfQueryINTEL(GLuint queryId, GLuint* queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glCreatePerfQueryINTEL;

        /// <summary>void glDeletePerfQueryINTEL(GLuint queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDeletePerfQueryINTEL;

        /// <summary>void glEndPerfQueryINTEL(GLuint queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndPerfQueryINTEL;

        /// <summary>void glGetFirstPerfQueryIdINTEL(GLuint* queryId);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glGetFirstPerfQueryIdINTEL;

        /// <summary>void glGetNextPerfQueryIdINTEL(GLuint queryId, GLuint* nextQueryId);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glGetNextPerfQueryIdINTEL;

        /// <summary>void glGetPerfCounterInfoINTEL(GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar* counterName, GLuint counterDescLength, GLchar* counterDesc, GLuint* counterOffset, GLuint* counterDataSize, GLuint* counterTypeEnum, GLuint* counterDataTypeEnum, GLuint64* rawCounterMaxValue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLchar*, GLuint, GLchar*, GLuint*, GLuint*, GLuint*, GLuint*, GLuint64*, void> glGetPerfCounterInfoINTEL;

        /// <summary>void glGetPerfQueryDataINTEL(GLuint queryHandle, GLuint flags, GLsizei dataSize, void* data, GLuint* bytesWritten);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, void*, GLuint*, void> glGetPerfQueryDataINTEL;

        /// <summary>void glGetPerfQueryIdByNameINTEL(GLchar* queryName, GLuint* queryId);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLchar*, GLuint*, void> glGetPerfQueryIdByNameINTEL;

        /// <summary>void glGetPerfQueryInfoINTEL(GLuint queryId, GLuint queryNameLength, GLchar* queryName, GLuint* dataSize, GLuint* noCounters, GLuint* noInstances, GLuint* capsMask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLchar*, GLuint*, GLuint*, GLuint*, GLuint*, void> glGetPerfQueryInfoINTEL;
    }
}
#endif