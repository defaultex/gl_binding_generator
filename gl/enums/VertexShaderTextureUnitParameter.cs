#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum VertexShaderTextureUnitParameter : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CurrentTextureCoords = gl.Constants.GL_CURRENT_TEXTURE_COORDS, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureMatrix = gl.Constants.GL_TEXTURE_MATRIX, 
#endif

}

#endif
