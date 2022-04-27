#if GL_ARB_IMAGING

public enum ColorTableParameterPName : GLenum { 
#if GL_ARB_IMAGING
    Scale = gl.Constants.GL_COLOR_TABLE_SCALE, 
#endif

#if GL_ARB_IMAGING
    Bias = gl.Constants.GL_COLOR_TABLE_BIAS, 
#endif

#if GL_ARB_IMAGING
    Format = gl.Constants.GL_COLOR_TABLE_FORMAT, 
#endif

#if GL_ARB_IMAGING
    Width = gl.Constants.GL_COLOR_TABLE_WIDTH, 
#endif

#if GL_ARB_IMAGING
    RedSize = gl.Constants.GL_COLOR_TABLE_RED_SIZE, 
#endif

#if GL_ARB_IMAGING
    GreenSize = gl.Constants.GL_COLOR_TABLE_GREEN_SIZE, 
#endif

#if GL_ARB_IMAGING
    BlueSize = gl.Constants.GL_COLOR_TABLE_BLUE_SIZE, 
#endif

#if GL_ARB_IMAGING
    AlphaSize = gl.Constants.GL_COLOR_TABLE_ALPHA_SIZE, 
#endif

#if GL_ARB_IMAGING
    LuminanceSize = gl.Constants.GL_COLOR_TABLE_LUMINANCE_SIZE, 
#endif

#if GL_ARB_IMAGING
    IntensitySize = gl.Constants.GL_COLOR_TABLE_INTENSITY_SIZE, 
#endif

}

#endif
