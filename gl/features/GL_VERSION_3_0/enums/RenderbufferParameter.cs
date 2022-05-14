public enum RenderbufferParameter : GLenum {
    RenderbufferSamples = gl.Constants.GL_RENDERBUFFER_SAMPLES,
    RenderbufferWidth = gl.Constants.GL_RENDERBUFFER_WIDTH,
    RenderbufferHeight = gl.Constants.GL_RENDERBUFFER_HEIGHT,
    RenderbufferInternalFormat = gl.Constants.GL_RENDERBUFFER_INTERNAL_FORMAT,
    RenderbufferRedSize = gl.Constants.GL_RENDERBUFFER_RED_SIZE,
    RenderbufferGreenSize = gl.Constants.GL_RENDERBUFFER_GREEN_SIZE,
    RenderbufferBlueSize = gl.Constants.GL_RENDERBUFFER_BLUE_SIZE,
    RenderbufferAlphaSize = gl.Constants.GL_RENDERBUFFER_ALPHA_SIZE,
    RenderbufferDepthSize = gl.Constants.GL_RENDERBUFFER_DEPTH_SIZE,
    RenderbufferStencilSize = gl.Constants.GL_RENDERBUFFER_STENCIL_SIZE,
#if GL_AMD_framebuffer_multisample_advanced
    RenderbufferStorageSamplesAmd = gl.Constants.GL_RENDERBUFFER_STORAGE_SAMPLES_AMD,
#endif

#if GL_NV_framebuffer_multisample_coverage
    RenderbufferCoverageSamplesNv = gl.Constants.GL_RENDERBUFFER_COVERAGE_SAMPLES_NV,
#endif

#if GL_NV_framebuffer_multisample_coverage
    RenderbufferColorSamplesNv = gl.Constants.GL_RENDERBUFFER_COLOR_SAMPLES_NV,
#endif
}
