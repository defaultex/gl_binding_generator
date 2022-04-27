#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)

public enum PrecisionType : GLenum { 
#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    LowFloat = gl.Constants.GL_LOW_FLOAT, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    MediumFloat = gl.Constants.GL_MEDIUM_FLOAT, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    HighFloat = gl.Constants.GL_HIGH_FLOAT, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    LowInt = gl.Constants.GL_LOW_INT, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    MediumInt = gl.Constants.GL_MEDIUM_INT, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    HighInt = gl.Constants.GL_HIGH_INT, 
#endif

}

#endif
