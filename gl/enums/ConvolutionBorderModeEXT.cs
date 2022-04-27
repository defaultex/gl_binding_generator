#if (GL_ARB_IMAGING || GL_EXT_CONVOLUTION)

public enum ConvolutionBorderModeEXT : GLenum { 
#if GL_ARB_IMAGING
    Reduce = gl.Constants.GL_REDUCE, 
#endif

#if GL_EXT_CONVOLUTION
    ReduceExt = gl.Constants.GL_REDUCE_EXT, 
#endif

}

#endif
