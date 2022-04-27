#if GL_NV_PATH_RENDERING

public enum PathStringFormat : GLenum { 
#if GL_NV_PATH_RENDERING
    FormatSvgNv = gl.Constants.GL_PATH_FORMAT_SVG_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FormatPsNv = gl.Constants.GL_PATH_FORMAT_PS_NV, 
#endif

}

#endif
