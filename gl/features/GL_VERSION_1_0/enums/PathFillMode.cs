public enum PathFillMode : GLenum {
    Invert = gl.Constants.GL_INVERT,
#if GL_NV_path_rendering
    PathFillModeNv = gl.Constants.GL_PATH_FILL_MODE_NV,
#endif

#if GL_NV_path_rendering
    CountUpNv = gl.Constants.GL_COUNT_UP_NV,
#endif

#if GL_NV_path_rendering
    CountDownNv = gl.Constants.GL_COUNT_DOWN_NV,
#endif
}
