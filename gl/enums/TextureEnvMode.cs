#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_EXT_TEXTURE || GL_SGIX_TEXTURE_ADD_ENV)

public enum TextureEnvMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Blend = gl.Constants.GL_BLEND, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Add = gl.Constants.GL_ADD, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Modulate = gl.Constants.GL_MODULATE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Decal = gl.Constants.GL_DECAL, 
#endif

#if GL_EXT_TEXTURE
    ReplaceExt = gl.Constants.GL_REPLACE_EXT, 
#endif

#if GL_SGIX_TEXTURE_ADD_ENV
    BiasSgix = gl.Constants.GL_TEXTURE_ENV_BIAS_SGIX, 
#endif

}

#endif
