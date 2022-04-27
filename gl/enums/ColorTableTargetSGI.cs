#if (GL_ARB_IMAGING || GL_SGI_COLOR_TABLE || GL_SGI_TEXTURE_COLOR_TABLE)

public enum ColorTableTargetSGI : GLenum { 
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

#if GL_SGI_COLOR_TABLE
    Sgi = gl.Constants.GL_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    PostConvolutionColorTableSgi = gl.Constants.GL_POST_CONVOLUTION_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    PostColorMatrixColorTableSgi = gl.Constants.GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ProxyColorTableSgi = gl.Constants.GL_PROXY_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ProxyPostConvolutionColorTableSgi = gl.Constants.GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ProxyPostColorMatrixColorTableSgi = gl.Constants.GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_TEXTURE_COLOR_TABLE
    TextureColorTableSgi = gl.Constants.GL_TEXTURE_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_TEXTURE_COLOR_TABLE
    ProxyTextureColorTableSgi = gl.Constants.GL_PROXY_TEXTURE_COLOR_TABLE_SGI, 
#endif

}

#endif
