#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0 || GL_ES_VERSION_3_0 || GL_OES_FRAMEBUFFER_OBJECT)

public enum FramebufferTarget : GLenum { 
#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    Framebuffer = gl.Constants.GL_FRAMEBUFFER, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ReadFramebuffer = gl.Constants.GL_READ_FRAMEBUFFER, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    DrawFramebuffer = gl.Constants.GL_DRAW_FRAMEBUFFER, 
#endif

#if GL_OES_FRAMEBUFFER_OBJECT
    Oes = gl.Constants.GL_FRAMEBUFFER_OES, 
#endif

}

#endif
