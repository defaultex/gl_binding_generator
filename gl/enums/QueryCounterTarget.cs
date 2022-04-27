#if (GL_ARB_TIMER_QUERY || GL_VERSION_3_3)

public enum QueryCounterTarget : GLenum { 
#if (GL_ARB_TIMER_QUERY || GL_VERSION_3_3)
    Timestamp = gl.Constants.GL_TIMESTAMP, 
#endif

}

#endif
