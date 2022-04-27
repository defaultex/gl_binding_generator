#if (GL_ARB_IMAGING || GL_SGI_COLOR_TABLE)

public enum GetColorTableParameterPNameSGI : GLenum { 
#if GL_ARB_IMAGING
    ColorTableScale = gl.Constants.GL_COLOR_TABLE_SCALE, 
#endif

#if GL_ARB_IMAGING
    ColorTableBias = gl.Constants.GL_COLOR_TABLE_BIAS, 
#endif

#if GL_ARB_IMAGING
    ColorTableFormat = gl.Constants.GL_COLOR_TABLE_FORMAT, 
#endif

#if GL_ARB_IMAGING
    ColorTableWidth = gl.Constants.GL_COLOR_TABLE_WIDTH, 
#endif

#if GL_ARB_IMAGING
    ColorTableRedSize = gl.Constants.GL_COLOR_TABLE_RED_SIZE, 
#endif

#if GL_ARB_IMAGING
    ColorTableGreenSize = gl.Constants.GL_COLOR_TABLE_GREEN_SIZE, 
#endif

#if GL_ARB_IMAGING
    ColorTableBlueSize = gl.Constants.GL_COLOR_TABLE_BLUE_SIZE, 
#endif

#if GL_ARB_IMAGING
    ColorTableAlphaSize = gl.Constants.GL_COLOR_TABLE_ALPHA_SIZE, 
#endif

#if GL_ARB_IMAGING
    ColorTableLuminanceSize = gl.Constants.GL_COLOR_TABLE_LUMINANCE_SIZE, 
#endif

#if GL_ARB_IMAGING
    ColorTableIntensitySize = gl.Constants.GL_COLOR_TABLE_INTENSITY_SIZE, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableScaleSgi = gl.Constants.GL_COLOR_TABLE_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableBiasSgi = gl.Constants.GL_COLOR_TABLE_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableFormatSgi = gl.Constants.GL_COLOR_TABLE_FORMAT_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableWidthSgi = gl.Constants.GL_COLOR_TABLE_WIDTH_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableRedSizeSgi = gl.Constants.GL_COLOR_TABLE_RED_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableGreenSizeSgi = gl.Constants.GL_COLOR_TABLE_GREEN_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableBlueSizeSgi = gl.Constants.GL_COLOR_TABLE_BLUE_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableAlphaSizeSgi = gl.Constants.GL_COLOR_TABLE_ALPHA_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableLuminanceSizeSgi = gl.Constants.GL_COLOR_TABLE_LUMINANCE_SIZE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableIntensitySizeSgi = gl.Constants.GL_COLOR_TABLE_INTENSITY_SIZE_SGI, 
#endif

}

#endif
