#if GL_VERSION_1_0

public enum RenderingMode : GLenum { 
#if GL_VERSION_1_0
    Render = gl.Constants.GL_RENDER, 
#endif

#if GL_VERSION_1_0
    Feedback = gl.Constants.GL_FEEDBACK, 
#endif

#if GL_VERSION_1_0
    Select = gl.Constants.GL_SELECT, 
#endif

}

#endif
