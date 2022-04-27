#if (GL_ES_VERSION_2_0 || GL_NV_BLEND_EQUATION_ADVANCED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_NV_PATH_RENDERING)

public enum PathFillMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_NV_BLEND_EQUATION_ADVANCED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Invert = gl.Constants.GL_INVERT, 
#endif

#if GL_NV_PATH_RENDERING
    ModeNv = gl.Constants.GL_PATH_FILL_MODE_NV, 
#endif

#if GL_NV_PATH_RENDERING
    CountUpNv = gl.Constants.GL_COUNT_UP_NV, 
#endif

#if GL_NV_PATH_RENDERING
    CountDownNv = gl.Constants.GL_COUNT_DOWN_NV, 
#endif

}

#endif
