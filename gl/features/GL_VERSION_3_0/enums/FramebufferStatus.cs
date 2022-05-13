public enum FramebufferStatus : GLenum {
    FramebufferUndefined = gl.Constants.GL_FRAMEBUFFER_UNDEFINED,
    FramebufferComplete = gl.Constants.GL_FRAMEBUFFER_COMPLETE,
    FramebufferIncompleteAttachment = gl.Constants.GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT,
    FramebufferIncompleteMissingAttachment = gl.Constants.GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT,
    FramebufferIncompleteDrawBuffer = gl.Constants.GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER,
    FramebufferIncompleteReadBuffer = gl.Constants.GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER,
    FramebufferUnsupported = gl.Constants.GL_FRAMEBUFFER_UNSUPPORTED,
    FramebufferIncompleteMultisample = gl.Constants.GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE,
    FramebufferIncompleteLayerTargets = gl.Constants.GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS,
}
