#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum TextureEnvParameter : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Mode = gl.Constants.GL_TEXTURE_ENV_MODE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Color = gl.Constants.GL_TEXTURE_ENV_COLOR, 
#endif

}

#endif
