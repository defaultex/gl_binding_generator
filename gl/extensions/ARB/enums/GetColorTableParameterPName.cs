#if GL_ARB_IMAGING

public enum GetColorTableParameterPName : GLenum { 
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

}

#endif
