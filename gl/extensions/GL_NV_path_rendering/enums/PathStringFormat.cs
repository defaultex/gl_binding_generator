#if GL_NV_path_rendering

public enum PathStringFormat : GLenum {
#if GL_NV_path_rendering
    PathFormatSvgNv = gl.Constants.GL_PATH_FORMAT_SVG_NV,
#endif

#if GL_NV_path_rendering
    PathFormatPsNv = gl.Constants.GL_PATH_FORMAT_PS_NV,
#endif
}

#endif