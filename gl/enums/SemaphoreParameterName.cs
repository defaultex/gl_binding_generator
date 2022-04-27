#if (GL_EXT_SEMAPHORE_WIN32 || GL_NV_TIMELINE_SEMAPHORE)

public enum SemaphoreParameterName : GLenum { 
#if GL_EXT_SEMAPHORE_WIN32
    D3d12FenceValueExt = gl.Constants.GL_D3D12_FENCE_VALUE_EXT, 
#endif

#if GL_NV_TIMELINE_SEMAPHORE
    TimelineSemaphoreValueNv = gl.Constants.GL_TIMELINE_SEMAPHORE_VALUE_NV, 
#endif

#if GL_NV_TIMELINE_SEMAPHORE
    TypeNv = gl.Constants.GL_SEMAPHORE_TYPE_NV, 
#endif

#if GL_NV_TIMELINE_SEMAPHORE
    TypeBinaryNv = gl.Constants.GL_SEMAPHORE_TYPE_BINARY_NV, 
#endif

#if GL_NV_TIMELINE_SEMAPHORE
    TypeTimelineNv = gl.Constants.GL_SEMAPHORE_TYPE_TIMELINE_NV, 
#endif

}

#endif
