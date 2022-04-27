#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)

public enum SyncParameterName : GLenum { 
#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    ObjectType = gl.Constants.GL_OBJECT_TYPE, 
#endif

#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    Condition = gl.Constants.GL_SYNC_CONDITION, 
#endif

#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    Status = gl.Constants.GL_SYNC_STATUS, 
#endif

#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    Flags = gl.Constants.GL_SYNC_FLAGS, 
#endif

}

#endif
