#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)

public enum Buffer : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Color = gl.Constants.GL_COLOR, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Depth = gl.Constants.GL_DEPTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Stencil = gl.Constants.GL_STENCIL, 
#endif

}

#endif
