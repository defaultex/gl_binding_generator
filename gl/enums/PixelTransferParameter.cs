#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ARB_IMAGING || GL_EXT_CONVOLUTION || GL_SGI_COLOR_MATRIX)

public enum PixelTransferParameter : GLenum { 
#if GL_VERSION_1_0
    MapColor = gl.Constants.GL_MAP_COLOR, 
#endif

#if GL_VERSION_1_0
    MapStencil = gl.Constants.GL_MAP_STENCIL, 
#endif

#if GL_VERSION_1_0
    IndexShift = gl.Constants.GL_INDEX_SHIFT, 
#endif

#if GL_VERSION_1_0
    IndexOffset = gl.Constants.GL_INDEX_OFFSET, 
#endif

#if GL_VERSION_1_0
    RedScale = gl.Constants.GL_RED_SCALE, 
#endif

#if GL_VERSION_1_0
    RedBias = gl.Constants.GL_RED_BIAS, 
#endif

#if GL_VERSION_1_0
    GreenScale = gl.Constants.GL_GREEN_SCALE, 
#endif

#if GL_VERSION_1_0
    GreenBias = gl.Constants.GL_GREEN_BIAS, 
#endif

#if GL_VERSION_1_0
    BlueScale = gl.Constants.GL_BLUE_SCALE, 
#endif

#if GL_VERSION_1_0
    BlueBias = gl.Constants.GL_BLUE_BIAS, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AlphaScale = gl.Constants.GL_ALPHA_SCALE, 
#endif

#if GL_VERSION_1_0
    AlphaBias = gl.Constants.GL_ALPHA_BIAS, 
#endif

#if GL_VERSION_1_0
    DepthScale = gl.Constants.GL_DEPTH_SCALE, 
#endif

#if GL_VERSION_1_0
    DepthBias = gl.Constants.GL_DEPTH_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionRedScale = gl.Constants.GL_POST_CONVOLUTION_RED_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionGreenScale = gl.Constants.GL_POST_CONVOLUTION_GREEN_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionBlueScale = gl.Constants.GL_POST_CONVOLUTION_BLUE_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionAlphaScale = gl.Constants.GL_POST_CONVOLUTION_ALPHA_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionRedBias = gl.Constants.GL_POST_CONVOLUTION_RED_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionGreenBias = gl.Constants.GL_POST_CONVOLUTION_GREEN_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionBlueBias = gl.Constants.GL_POST_CONVOLUTION_BLUE_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionAlphaBias = gl.Constants.GL_POST_CONVOLUTION_ALPHA_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixRedScale = gl.Constants.GL_POST_COLOR_MATRIX_RED_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixGreenScale = gl.Constants.GL_POST_COLOR_MATRIX_GREEN_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixBlueScale = gl.Constants.GL_POST_COLOR_MATRIX_BLUE_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixAlphaScale = gl.Constants.GL_POST_COLOR_MATRIX_ALPHA_SCALE, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixRedBias = gl.Constants.GL_POST_COLOR_MATRIX_RED_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixGreenBias = gl.Constants.GL_POST_COLOR_MATRIX_GREEN_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixBlueBias = gl.Constants.GL_POST_COLOR_MATRIX_BLUE_BIAS, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixAlphaBias = gl.Constants.GL_POST_COLOR_MATRIX_ALPHA_BIAS, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionRedScaleExt = gl.Constants.GL_POST_CONVOLUTION_RED_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionGreenScaleExt = gl.Constants.GL_POST_CONVOLUTION_GREEN_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionBlueScaleExt = gl.Constants.GL_POST_CONVOLUTION_BLUE_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionAlphaScaleExt = gl.Constants.GL_POST_CONVOLUTION_ALPHA_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionRedBiasExt = gl.Constants.GL_POST_CONVOLUTION_RED_BIAS_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionGreenBiasExt = gl.Constants.GL_POST_CONVOLUTION_GREEN_BIAS_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionBlueBiasExt = gl.Constants.GL_POST_CONVOLUTION_BLUE_BIAS_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionAlphaBiasExt = gl.Constants.GL_POST_CONVOLUTION_ALPHA_BIAS_EXT, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixRedScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_RED_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixGreenScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixBlueScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixAlphaScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixRedBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_RED_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixGreenBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixBlueBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixAlphaBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI, 
#endif

}

#endif
