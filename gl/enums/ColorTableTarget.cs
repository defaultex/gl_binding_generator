#if GL_ARB_IMAGING

public enum ColorTableTarget : GLenum { 
#if GL_ARB_IMAGING
    Table = gl.Constants.GL_COLOR_TABLE, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionColorTable = gl.Constants.GL_POST_CONVOLUTION_COLOR_TABLE, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixColorTable = gl.Constants.GL_POST_COLOR_MATRIX_COLOR_TABLE, 
#endif

#if GL_ARB_IMAGING
    ProxyColorTable = gl.Constants.GL_PROXY_COLOR_TABLE, 
#endif

#if GL_ARB_IMAGING
    ProxyPostConvolutionColorTable = gl.Constants.GL_PROXY_POST_CONVOLUTION_COLOR_TABLE, 
#endif

#if GL_ARB_IMAGING
    ProxyPostColorMatrixColorTable = gl.Constants.GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE, 
#endif

}

#endif
