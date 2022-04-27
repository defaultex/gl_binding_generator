#if (GL_VERSION_3_0 || GL_ARB_CONDITIONAL_RENDER_INVERTED || GL_VERSION_4_5)

public enum ConditionalRenderMode : GLenum { 
#if GL_VERSION_3_0
    QueryWait = gl.Constants.GL_QUERY_WAIT, 
#endif

#if GL_VERSION_3_0
    QueryNoWait = gl.Constants.GL_QUERY_NO_WAIT, 
#endif

#if GL_VERSION_3_0
    QueryByRegionWait = gl.Constants.GL_QUERY_BY_REGION_WAIT, 
#endif

#if GL_VERSION_3_0
    QueryByRegionNoWait = gl.Constants.GL_QUERY_BY_REGION_NO_WAIT, 
#endif

#if (GL_ARB_CONDITIONAL_RENDER_INVERTED || GL_VERSION_4_5)
    QueryWaitInverted = gl.Constants.GL_QUERY_WAIT_INVERTED, 
#endif

#if (GL_ARB_CONDITIONAL_RENDER_INVERTED || GL_VERSION_4_5)
    QueryNoWaitInverted = gl.Constants.GL_QUERY_NO_WAIT_INVERTED, 
#endif

#if (GL_ARB_CONDITIONAL_RENDER_INVERTED || GL_VERSION_4_5)
    QueryByRegionWaitInverted = gl.Constants.GL_QUERY_BY_REGION_WAIT_INVERTED, 
#endif

#if (GL_ARB_CONDITIONAL_RENDER_INVERTED || GL_VERSION_4_5)
    QueryByRegionNoWaitInverted = gl.Constants.GL_QUERY_BY_REGION_NO_WAIT_INVERTED, 
#endif

}

#endif
