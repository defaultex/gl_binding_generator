#if (GL_VERSION_3_0 || GL_ARB_COLOR_BUFFER_FLOAT)

public enum ClampColorTargetARB : GLenum { 
#if GL_VERSION_3_0
    ReadColor = gl.Constants.GL_CLAMP_READ_COLOR, 
#endif

#if GL_ARB_COLOR_BUFFER_FLOAT
    VertexColorArb = gl.Constants.GL_CLAMP_VERTEX_COLOR_ARB, 
#endif

#if GL_ARB_COLOR_BUFFER_FLOAT
    FragmentColorArb = gl.Constants.GL_CLAMP_FRAGMENT_COLOR_ARB, 
#endif

#if GL_ARB_COLOR_BUFFER_FLOAT
    ReadColorArb = gl.Constants.GL_CLAMP_READ_COLOR_ARB, 
#endif

}

#endif
