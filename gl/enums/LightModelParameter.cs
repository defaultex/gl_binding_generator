#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_VERSION_1_2 || GL_EXT_SEPARATE_SPECULAR_COLOR)

public enum LightModelParameter : GLenum { 
#if GL_VERSION_1_0
    LocalViewer = gl.Constants.GL_LIGHT_MODEL_LOCAL_VIEWER, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TwoSide = gl.Constants.GL_LIGHT_MODEL_TWO_SIDE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Ambient = gl.Constants.GL_LIGHT_MODEL_AMBIENT, 
#endif

#if GL_VERSION_1_2
    ColorControl = gl.Constants.GL_LIGHT_MODEL_COLOR_CONTROL, 
#endif

#if GL_EXT_SEPARATE_SPECULAR_COLOR
    ColorControlExt = gl.Constants.GL_LIGHT_MODEL_COLOR_CONTROL_EXT, 
#endif

}

#endif
