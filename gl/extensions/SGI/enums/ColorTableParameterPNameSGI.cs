#if (GL_ARB_IMAGING || GL_SGI_COLOR_TABLE)

public enum ColorTableParameterPNameSGI : GLenum { 
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

#if GL_SGI_COLOR_TABLE
    ScaleSgi = gl.Constants.GL_COLOR_TABLE_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    BiasSgi = gl.Constants.GL_COLOR_TABLE_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    FormatSgi = gl.Constants.GL_COLOR_TABLE_FORMAT_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    WidthSgi = gl.Constants.GL_COLOR_TABLE_WIDTH_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    RedSizeSgi = gl.Constants.GL_COLOR_TABLE_RED_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    GreenSizeSgi = gl.Constants.GL_COLOR_TABLE_GREEN_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    BlueSizeSgi = gl.Constants.GL_COLOR_TABLE_BLUE_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    AlphaSizeSgi = gl.Constants.GL_COLOR_TABLE_ALPHA_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    LuminanceSizeSgi = gl.Constants.GL_COLOR_TABLE_LUMINANCE_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    IntensitySizeSgi = gl.Constants.GL_COLOR_TABLE_INTENSITY_SIZE_SGI, 
#endif

}

#endif
