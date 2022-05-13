#if GL_NV_path_rendering

public enum PathFontTarget : GLenum {
#if GL_NV_path_rendering
    StandardFontNameNv = gl.Constants.GL_STANDARD_FONT_NAME_NV,
#endif

#if GL_NV_path_rendering
    SystemFontNameNv = gl.Constants.GL_SYSTEM_FONT_NAME_NV,
#endif

#if GL_NV_path_rendering
    FileNameNv = gl.Constants.GL_FILE_NAME_NV,
#endif
}

#endif