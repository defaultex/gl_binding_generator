#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)

public enum SyncStatus : GLenum { 
#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    AlreadySignaled = gl.Constants.GL_ALREADY_SIGNALED, 
#endif

#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    TimeoutExpired = gl.Constants.GL_TIMEOUT_EXPIRED, 
#endif

#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    ConditionSatisfied = gl.Constants.GL_CONDITION_SATISFIED, 
#endif

#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    WaitFailed = gl.Constants.GL_WAIT_FAILED, 
#endif

}

#endif
