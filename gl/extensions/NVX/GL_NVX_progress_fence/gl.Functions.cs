#if (GL_NVX_progress_fence && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClientWaitSemaphoreui64NVX(GLsizei fenceObjectCount, GLuint* semaphoreArray, GLuint64* fenceValueArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, GLuint64*, void> glClientWaitSemaphoreui64NVX;

        /// <summary>GLuint glCreateProgressFenceNVX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint> glCreateProgressFenceNVX;

        /// <summary>void glSignalSemaphoreui64NVX(GLuint signalGpu, GLsizei fenceObjectCount, GLuint* semaphoreArray, GLuint64* fenceValueArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLuint*, GLuint64*, void> glSignalSemaphoreui64NVX;

        /// <summary>void glWaitSemaphoreui64NVX(GLuint waitGpu, GLsizei fenceObjectCount, GLuint* semaphoreArray, GLuint64* fenceValueArray);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLuint*, GLuint64*, void> glWaitSemaphoreui64NVX;
    }
}
#endif