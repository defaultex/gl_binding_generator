#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0 || GL_ES_VERSION_3_0 || GL_VERSION_1_0 || GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT || GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS || GL_OES_FRAMEBUFFER_OBJECT)

public enum InvalidateFramebufferAttachment : GLenum { 
#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    ColorAttachment0 = gl.Constants.GL_COLOR_ATTACHMENT0, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    DepthAttachment = gl.Constants.GL_DEPTH_ATTACHMENT, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Color = gl.Constants.GL_COLOR, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Depth = gl.Constants.GL_DEPTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Stencil = gl.Constants.GL_STENCIL, 
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

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment0Ext = gl.Constants.GL_COLOR_ATTACHMENT0_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment1Ext = gl.Constants.GL_COLOR_ATTACHMENT1_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment2Ext = gl.Constants.GL_COLOR_ATTACHMENT2_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment3Ext = gl.Constants.GL_COLOR_ATTACHMENT3_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment4Ext = gl.Constants.GL_COLOR_ATTACHMENT4_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment5Ext = gl.Constants.GL_COLOR_ATTACHMENT5_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment6Ext = gl.Constants.GL_COLOR_ATTACHMENT6_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment7Ext = gl.Constants.GL_COLOR_ATTACHMENT7_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment8Ext = gl.Constants.GL_COLOR_ATTACHMENT8_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment9Ext = gl.Constants.GL_COLOR_ATTACHMENT9_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment10Ext = gl.Constants.GL_COLOR_ATTACHMENT10_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment11Ext = gl.Constants.GL_COLOR_ATTACHMENT11_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment12Ext = gl.Constants.GL_COLOR_ATTACHMENT12_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment13Ext = gl.Constants.GL_COLOR_ATTACHMENT13_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment14Ext = gl.Constants.GL_COLOR_ATTACHMENT14_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    ColorAttachment15Ext = gl.Constants.GL_COLOR_ATTACHMENT15_EXT, 
#endif

#if GL_EXT_FRAMEBUFFER_OBJECT
    DepthAttachmentExt = gl.Constants.GL_DEPTH_ATTACHMENT_EXT, 
#endif

#if GL_EXT_FRAMEBUFFER_OBJECT
    StencilAttachmentExt = gl.Constants.GL_STENCIL_ATTACHMENT_EXT, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment0Nv = gl.Constants.GL_COLOR_ATTACHMENT0_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment1Nv = gl.Constants.GL_COLOR_ATTACHMENT1_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment2Nv = gl.Constants.GL_COLOR_ATTACHMENT2_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment3Nv = gl.Constants.GL_COLOR_ATTACHMENT3_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment4Nv = gl.Constants.GL_COLOR_ATTACHMENT4_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment5Nv = gl.Constants.GL_COLOR_ATTACHMENT5_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment6Nv = gl.Constants.GL_COLOR_ATTACHMENT6_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment7Nv = gl.Constants.GL_COLOR_ATTACHMENT7_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment8Nv = gl.Constants.GL_COLOR_ATTACHMENT8_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment9Nv = gl.Constants.GL_COLOR_ATTACHMENT9_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment10Nv = gl.Constants.GL_COLOR_ATTACHMENT10_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment11Nv = gl.Constants.GL_COLOR_ATTACHMENT11_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment12Nv = gl.Constants.GL_COLOR_ATTACHMENT12_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment13Nv = gl.Constants.GL_COLOR_ATTACHMENT13_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment14Nv = gl.Constants.GL_COLOR_ATTACHMENT14_NV, 
#endif

#if (GL_NV_DRAW_BUFFERS || GL_NV_FBO_COLOR_ATTACHMENTS)
    ColorAttachment15Nv = gl.Constants.GL_COLOR_ATTACHMENT15_NV, 
#endif

#if GL_OES_FRAMEBUFFER_OBJECT
    ColorAttachment0Oes = gl.Constants.GL_COLOR_ATTACHMENT0_OES, 
#endif

#if GL_OES_FRAMEBUFFER_OBJECT
    DepthAttachmentOes = gl.Constants.GL_DEPTH_ATTACHMENT_OES, 
#endif

#if GL_OES_FRAMEBUFFER_OBJECT
    StencilAttachmentOes = gl.Constants.GL_STENCIL_ATTACHMENT_OES, 
#endif

}

#endif
