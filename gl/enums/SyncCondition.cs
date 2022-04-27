#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)

public enum SyncCondition : GLenum { 
#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    GpuCommandsComplete = gl.Constants.GL_SYNC_GPU_COMMANDS_COMPLETE, 
#endif

}

#endif
