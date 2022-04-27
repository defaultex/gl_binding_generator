#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_VERSION_3_0 || GL_ARB_COLOR_BUFFER_FLOAT)

public enum ClampColorModeARB : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    False = gl.Constants.GL_FALSE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    True = gl.Constants.GL_TRUE, 
#endif

#if GL_VERSION_3_0
    FixedOnly = gl.Constants.GL_FIXED_ONLY, 
#endif

#if GL_ARB_COLOR_BUFFER_FLOAT
    FixedOnlyArb = gl.Constants.GL_FIXED_ONLY_ARB, 
#endif

}

#endif
