#if (GL_INTEL_performance_query && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginPerfQueryINTEL(GLuint queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBeginPerfQueryINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCreatePerfQueryINTEL(GLuint queryId, GLuint* queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glCreatePerfQueryINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeletePerfQueryINTEL(GLuint queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDeletePerfQueryINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndPerfQueryINTEL(GLuint queryHandle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEndPerfQueryINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFirstPerfQueryIdINTEL(GLuint* queryId);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glGetFirstPerfQueryIdINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNextPerfQueryIdINTEL(GLuint queryId, GLuint* nextQueryId);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glGetNextPerfQueryIdINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfCounterInfoINTEL(GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar* counterName, GLuint counterDescLength, GLchar* counterDesc, GLuint* counterOffset, GLuint* counterDataSize, GLuint* counterTypeEnum, GLuint* counterDataTypeEnum, GLuint64* rawCounterMaxValue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLchar*, GLuint, GLchar*, GLuint*, GLuint*, GLuint*, GLuint*, GLuint64*, void> glGetPerfCounterInfoINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfQueryDataINTEL(GLuint queryHandle, GLuint flags, GLsizei dataSize, void* data, GLuint* bytesWritten);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, void*, GLuint*, void> glGetPerfQueryDataINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfQueryIdByNameINTEL(GLchar* queryName, GLuint* queryId);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLchar*, GLuint*, void> glGetPerfQueryIdByNameINTEL;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPerfQueryInfoINTEL(GLuint queryId, GLuint queryNameLength, GLchar* queryName, GLuint* dataSize, GLuint* noCounters, GLuint* noInstances, GLuint* capsMask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLchar*, GLuint*, GLuint*, GLuint*, GLuint*, void> glGetPerfQueryInfoINTEL;
#endif
    }
}
#endif