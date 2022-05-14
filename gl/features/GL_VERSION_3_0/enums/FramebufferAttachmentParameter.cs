public enum FramebufferAttachmentParameter : GLenum {
    FramebufferAttachmentColorEncoding = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING,
    FramebufferAttachmentComponentType = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE,
    FramebufferAttachmentRedSize = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE,
    FramebufferAttachmentGreenSize = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE,
    FramebufferAttachmentBlueSize = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE,
    FramebufferAttachmentAlphaSize = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE,
    FramebufferAttachmentDepthSize = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE,
    FramebufferAttachmentStencilSize = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE,
    FramebufferAttachmentObjectType = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE,
    FramebufferAttachmentObjectName = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME,
    FramebufferAttachmentTextureLevel = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL,
    FramebufferAttachmentTextureCubeMapFace = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE,
    FramebufferAttachmentTextureLayer = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER,
    FramebufferAttachmentLayered = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_LAYERED,
#if GL_ARB_geometry_shader4
    FramebufferAttachmentLayeredArb = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB,
#endif

#if GL_OVR_multiview
    FramebufferAttachmentTextureNumViewsOvr = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR,
#endif

#if GL_OVR_multiview
    FramebufferAttachmentTextureBaseViewIndexOvr = gl.Constants.GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR,
#endif
}
