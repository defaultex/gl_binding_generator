#if (GL_ARB_IMAGING || GL_EXT_CONVOLUTION)

public enum ConvolutionTargetEXT : GLenum { 
#if GL_ARB_IMAGING
    Convolution1D = gl.Constants.GL_CONVOLUTION_1D, 
#endif

#if GL_ARB_IMAGING
    Convolution2D = gl.Constants.GL_CONVOLUTION_2D, 
#endif

#if GL_EXT_CONVOLUTION
    Convolution1DExt = gl.Constants.GL_CONVOLUTION_1D_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    Convolution2DExt = gl.Constants.GL_CONVOLUTION_2D_EXT, 
#endif

}

#endif
