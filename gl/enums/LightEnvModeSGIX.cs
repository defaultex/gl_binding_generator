#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum LightEnvModeSGIX : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Replace = gl.Constants.GL_REPLACE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Add = gl.Constants.GL_ADD, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Modulate = gl.Constants.GL_MODULATE, 
#endif

}

#endif
