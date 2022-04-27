#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5 || GL_ARB_QUERY_BUFFER_OBJECT || GL_VERSION_4_4 || GL_ARB_DIRECT_STATE_ACCESS || GL_VERSION_4_5)

public enum QueryObjectParameterName : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    Result = gl.Constants.GL_QUERY_RESULT, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    ResultAvailable = gl.Constants.GL_QUERY_RESULT_AVAILABLE, 
#endif

#if (GL_ARB_QUERY_BUFFER_OBJECT || GL_VERSION_4_4)
    ResultNoWait = gl.Constants.GL_QUERY_RESULT_NO_WAIT, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_VERSION_4_5)
    Target = gl.Constants.GL_QUERY_TARGET, 
#endif

}

#endif
