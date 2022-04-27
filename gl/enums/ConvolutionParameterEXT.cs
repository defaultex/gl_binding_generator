#if (GL_ARB_IMAGING || GL_EXT_CONVOLUTION)

public enum ConvolutionParameterEXT : GLenum { 
#if GL_ARB_IMAGING
    BorderMode = gl.Constants.GL_CONVOLUTION_BORDER_MODE, 
#endif

#if GL_ARB_IMAGING
    FilterScale = gl.Constants.GL_CONVOLUTION_FILTER_SCALE, 
#endif

#if GL_ARB_IMAGING
    FilterBias = gl.Constants.GL_CONVOLUTION_FILTER_BIAS, 
#endif

#if GL_EXT_CONVOLUTION
    BorderModeExt = gl.Constants.GL_CONVOLUTION_BORDER_MODE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    FilterScaleExt = gl.Constants.GL_CONVOLUTION_FILTER_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    FilterBiasExt = gl.Constants.GL_CONVOLUTION_FILTER_BIAS_EXT, 
#endif

}

#endif
