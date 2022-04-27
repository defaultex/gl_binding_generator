#if (GL_ARB_IMAGING || GL_EXT_CONVOLUTION)

public enum SeparableTargetEXT : GLenum { 
#if GL_ARB_IMAGING
    Separable2D = gl.Constants.GL_SEPARABLE_2D, 
#endif

#if GL_EXT_CONVOLUTION
    Separable2DExt = gl.Constants.GL_SEPARABLE_2D_EXT, 
#endif

}

#endif
