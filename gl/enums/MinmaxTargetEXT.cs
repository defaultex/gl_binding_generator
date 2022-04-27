#if (GL_ARB_IMAGING || GL_EXT_HISTOGRAM)

public enum MinmaxTargetEXT : GLenum { 
#if GL_ARB_IMAGING
    Minmax = gl.Constants.GL_MINMAX, 
#endif

#if GL_EXT_HISTOGRAM
    Ext = gl.Constants.GL_MINMAX_EXT, 
#endif

}

#endif
