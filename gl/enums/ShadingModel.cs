#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum ShadingModel : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Flat = gl.Constants.GL_FLAT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Smooth = gl.Constants.GL_SMOOTH, 
#endif

}

#endif
