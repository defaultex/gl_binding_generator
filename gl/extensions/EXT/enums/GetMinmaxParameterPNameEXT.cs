#if (GL_ARB_IMAGING || GL_EXT_HISTOGRAM)

public enum GetMinmaxParameterPNameEXT : GLenum { 
#if GL_ARB_IMAGING
    MinmaxFormat = gl.Constants.GL_MINMAX_FORMAT, 
#endif

#if GL_ARB_IMAGING
    MinmaxSink = gl.Constants.GL_MINMAX_SINK, 
#endif

#if GL_EXT_HISTOGRAM
    MinmaxFormatExt = gl.Constants.GL_MINMAX_FORMAT_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    MinmaxSinkExt = gl.Constants.GL_MINMAX_SINK_EXT, 
#endif

}

#endif
