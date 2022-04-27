#if (GL_ARB_IMAGING || GL_EXT_HISTOGRAM)

public enum HistogramTargetEXT : GLenum { 
#if GL_ARB_IMAGING
    Histogram = gl.Constants.GL_HISTOGRAM, 
#endif

#if GL_ARB_IMAGING
    ProxyHistogram = gl.Constants.GL_PROXY_HISTOGRAM, 
#endif

#if GL_EXT_HISTOGRAM
    Ext = gl.Constants.GL_HISTOGRAM_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    ProxyHistogramExt = gl.Constants.GL_PROXY_HISTOGRAM_EXT, 
#endif

}

#endif
