#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)

public enum QueryParameterName : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_1_5)
    CurrentQuery = gl.Constants.GL_CURRENT_QUERY, 
#endif

#if GL_VERSION_1_5
    Counter = gl.Constants.GL_QUERY_COUNTER_BITS, 
#endif

}

#endif
