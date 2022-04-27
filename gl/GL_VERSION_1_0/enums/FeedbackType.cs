#if GL_VERSION_1_0

public enum FeedbackType : GLenum { 
#if GL_VERSION_1_0
    _2D = gl.Constants.GL_2D, 
#endif

#if GL_VERSION_1_0
    _3D = gl.Constants.GL_3D, 
#endif

#if GL_VERSION_1_0
    _3DColor = gl.Constants.GL_3D_COLOR, 
#endif

#if GL_VERSION_1_0
    _3DColorTexture = gl.Constants.GL_3D_COLOR_TEXTURE, 
#endif

#if GL_VERSION_1_0
    _4dColorTexture = gl.Constants.GL_4D_COLOR_TEXTURE, 
#endif

}

#endif
