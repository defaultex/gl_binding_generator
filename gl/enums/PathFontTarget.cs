#if GL_NV_PATH_RENDERING

public enum PathFontTarget : GLenum { 
#if GL_NV_PATH_RENDERING
    StandardNameNv = gl.Constants.GL_STANDARD_FONT_NAME_NV, 
#endif

#if GL_NV_PATH_RENDERING
    SystemNameNv = gl.Constants.GL_SYSTEM_FONT_NAME_NV, 
#endif

#if GL_NV_PATH_RENDERING
    FileNameNv = gl.Constants.GL_FILE_NAME_NV, 
#endif

}

#endif
