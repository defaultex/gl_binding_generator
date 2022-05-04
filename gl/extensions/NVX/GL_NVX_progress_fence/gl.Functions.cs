#if (GL_NVX_progress_fence && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClientWaitSemaphoreui64NVX(GLsizei fenceObjectCount, GLuint* semaphoreArray, GLuint64* fenceValueArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, GLuint64*, void> glClientWaitSemaphoreui64NVX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glCreateProgressFenceNVX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint> glCreateProgressFenceNVX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSignalSemaphoreui64NVX(GLuint signalGpu, GLsizei fenceObjectCount, GLuint* semaphoreArray, GLuint64* fenceValueArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLuint*, GLuint64*, void> glSignalSemaphoreui64NVX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWaitSemaphoreui64NVX(GLuint waitGpu, GLsizei fenceObjectCount, GLuint* semaphoreArray, GLuint64* fenceValueArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLuint*, GLuint64*, void> glWaitSemaphoreui64NVX;
#endif
    }
}
#endif