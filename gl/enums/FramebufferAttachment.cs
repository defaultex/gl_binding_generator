#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0 || GL_ES_VERSION_3_0)

public enum FramebufferAttachment : GLenum { 
#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    ColorAttachment0 = gl.Constants.GL_COLOR_ATTACHMENT0, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    DepthAttachment = gl.Constants.GL_DEPTH_ATTACHMENT, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    StencilAttachment = gl.Constants.GL_STENCIL_ATTACHMENT, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    DepthStencilAttachment = gl.Constants.GL_DEPTH_STENCIL_ATTACHMENT, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment1 = gl.Constants.GL_COLOR_ATTACHMENT1, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment2 = gl.Constants.GL_COLOR_ATTACHMENT2, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment3 = gl.Constants.GL_COLOR_ATTACHMENT3, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment4 = gl.Constants.GL_COLOR_ATTACHMENT4, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment5 = gl.Constants.GL_COLOR_ATTACHMENT5, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment6 = gl.Constants.GL_COLOR_ATTACHMENT6, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment7 = gl.Constants.GL_COLOR_ATTACHMENT7, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment8 = gl.Constants.GL_COLOR_ATTACHMENT8, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment9 = gl.Constants.GL_COLOR_ATTACHMENT9, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment10 = gl.Constants.GL_COLOR_ATTACHMENT10, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment11 = gl.Constants.GL_COLOR_ATTACHMENT11, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment12 = gl.Constants.GL_COLOR_ATTACHMENT12, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment13 = gl.Constants.GL_COLOR_ATTACHMENT13, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment14 = gl.Constants.GL_COLOR_ATTACHMENT14, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment15 = gl.Constants.GL_COLOR_ATTACHMENT15, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment16 = gl.Constants.GL_COLOR_ATTACHMENT16, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment17 = gl.Constants.GL_COLOR_ATTACHMENT17, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment18 = gl.Constants.GL_COLOR_ATTACHMENT18, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment19 = gl.Constants.GL_COLOR_ATTACHMENT19, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment20 = gl.Constants.GL_COLOR_ATTACHMENT20, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment21 = gl.Constants.GL_COLOR_ATTACHMENT21, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment22 = gl.Constants.GL_COLOR_ATTACHMENT22, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment23 = gl.Constants.GL_COLOR_ATTACHMENT23, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment24 = gl.Constants.GL_COLOR_ATTACHMENT24, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment25 = gl.Constants.GL_COLOR_ATTACHMENT25, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment26 = gl.Constants.GL_COLOR_ATTACHMENT26, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment27 = gl.Constants.GL_COLOR_ATTACHMENT27, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment28 = gl.Constants.GL_COLOR_ATTACHMENT28, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment29 = gl.Constants.GL_COLOR_ATTACHMENT29, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment30 = gl.Constants.GL_COLOR_ATTACHMENT30, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment31 = gl.Constants.GL_COLOR_ATTACHMENT31, 
#endif

}

#endif
