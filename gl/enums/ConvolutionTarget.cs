#if GL_ARB_IMAGING

public enum ConvolutionTarget : GLenum { 
#if GL_ARB_IMAGING
    Convolution1D = gl.Constants.GL_CONVOLUTION_1D, 
#endif

#if GL_ARB_IMAGING
    Convolution2D = gl.Constants.GL_CONVOLUTION_2D, 
#endif

}

#endif
