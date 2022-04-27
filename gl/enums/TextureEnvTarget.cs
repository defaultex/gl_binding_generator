#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum TextureEnvTarget : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Env = gl.Constants.GL_TEXTURE_ENV, 
#endif

}

#endif
