#if (GL_ARB_IMAGING || GL_EXT_CONVOLUTION)

public enum GetConvolutionParameter : GLenum { 
#if GL_ARB_IMAGING
    ConvolutionBorderMode = gl.Constants.GL_CONVOLUTION_BORDER_MODE, 
#endif

#if GL_ARB_IMAGING
    ConvolutionFilterScale = gl.Constants.GL_CONVOLUTION_FILTER_SCALE, 
#endif

#if GL_ARB_IMAGING
    ConvolutionFilterBias = gl.Constants.GL_CONVOLUTION_FILTER_BIAS, 
#endif

#if GL_ARB_IMAGING
    ConvolutionFormat = gl.Constants.GL_CONVOLUTION_FORMAT, 
#endif

#if GL_ARB_IMAGING
    ConvolutionWidth = gl.Constants.GL_CONVOLUTION_WIDTH, 
#endif

#if GL_ARB_IMAGING
    ConvolutionHeight = gl.Constants.GL_CONVOLUTION_HEIGHT, 
#endif

#if GL_ARB_IMAGING
    MaxWidth = gl.Constants.GL_MAX_CONVOLUTION_WIDTH, 
#endif

#if GL_ARB_IMAGING
    MaxHeight = gl.Constants.GL_MAX_CONVOLUTION_HEIGHT, 
#endif

#if GL_ARB_IMAGING
    ConvolutionBorderColor = gl.Constants.GL_CONVOLUTION_BORDER_COLOR, 
#endif

#if GL_EXT_CONVOLUTION
    ConvolutionBorderModeExt = gl.Constants.GL_CONVOLUTION_BORDER_MODE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    ConvolutionFilterScaleExt = gl.Constants.GL_CONVOLUTION_FILTER_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    ConvolutionFilterBiasExt = gl.Constants.GL_CONVOLUTION_FILTER_BIAS_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    ConvolutionFormatExt = gl.Constants.GL_CONVOLUTION_FORMAT_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    ConvolutionWidthExt = gl.Constants.GL_CONVOLUTION_WIDTH_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    ConvolutionHeightExt = gl.Constants.GL_CONVOLUTION_HEIGHT_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    MaxWidthExt = gl.Constants.GL_MAX_CONVOLUTION_WIDTH_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    MaxHeightExt = gl.Constants.GL_MAX_CONVOLUTION_HEIGHT_EXT, 
#endif

}

#endif
