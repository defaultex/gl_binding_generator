#if (GL_ARB_IMAGING || GL_EXT_HISTOGRAM)

public enum GetHistogramParameterPNameEXT : GLenum { 
#if GL_ARB_IMAGING
    HistogramWidth = gl.Constants.GL_HISTOGRAM_WIDTH, 
#endif

#if GL_ARB_IMAGING
    HistogramFormat = gl.Constants.GL_HISTOGRAM_FORMAT, 
#endif

#if GL_ARB_IMAGING
    HistogramRedSize = gl.Constants.GL_HISTOGRAM_RED_SIZE, 
#endif

#if GL_ARB_IMAGING
    HistogramGreenSize = gl.Constants.GL_HISTOGRAM_GREEN_SIZE, 
#endif

#if GL_ARB_IMAGING
    HistogramBlueSize = gl.Constants.GL_HISTOGRAM_BLUE_SIZE, 
#endif

#if GL_ARB_IMAGING
    HistogramAlphaSize = gl.Constants.GL_HISTOGRAM_ALPHA_SIZE, 
#endif

#if GL_ARB_IMAGING
    HistogramLuminanceSize = gl.Constants.GL_HISTOGRAM_LUMINANCE_SIZE, 
#endif

#if GL_ARB_IMAGING
    HistogramSink = gl.Constants.GL_HISTOGRAM_SINK, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramWidthExt = gl.Constants.GL_HISTOGRAM_WIDTH_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramFormatExt = gl.Constants.GL_HISTOGRAM_FORMAT_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramRedSizeExt = gl.Constants.GL_HISTOGRAM_RED_SIZE_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramGreenSizeExt = gl.Constants.GL_HISTOGRAM_GREEN_SIZE_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramBlueSizeExt = gl.Constants.GL_HISTOGRAM_BLUE_SIZE_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramAlphaSizeExt = gl.Constants.GL_HISTOGRAM_ALPHA_SIZE_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramLuminanceSizeExt = gl.Constants.GL_HISTOGRAM_LUMINANCE_SIZE_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramSinkExt = gl.Constants.GL_HISTOGRAM_SINK_EXT, 
#endif

}

#endif
