#if GL_ARB_IMAGING

public enum HistogramTarget : GLenum { 
#if GL_ARB_IMAGING
    Histogram = gl.Constants.GL_HISTOGRAM, 
#endif

#if GL_ARB_IMAGING
    ProxyHistogram = gl.Constants.GL_PROXY_HISTOGRAM, 
#endif

}

#endif
