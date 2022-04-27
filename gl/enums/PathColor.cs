#if (GL_NV_PATH_RENDERING || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0 || GL_NV_REGISTER_COMBINERS)

public enum PathColor : GLenum { 
#if (GL_NV_PATH_RENDERING || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    PrimaryColor = gl.Constants.GL_PRIMARY_COLOR, 
#endif

#if (GL_NV_PATH_RENDERING || GL_NV_REGISTER_COMBINERS)
    PrimaryColorNv = gl.Constants.GL_PRIMARY_COLOR_NV, 
#endif

#if (GL_NV_PATH_RENDERING || GL_NV_REGISTER_COMBINERS)
    SecondaryColorNv = gl.Constants.GL_SECONDARY_COLOR_NV, 
#endif

}

#endif
