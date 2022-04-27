#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0 || GL_EXT_DISCARD_FRAMEBUFFER)

public enum PixelCopyType : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Color = gl.Constants.GL_COLOR, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Depth = gl.Constants.GL_DEPTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Stencil = gl.Constants.GL_STENCIL, 
#endif

#if GL_EXT_DISCARD_FRAMEBUFFER
    ColorExt = gl.Constants.GL_COLOR_EXT, 
#endif

#if GL_EXT_DISCARD_FRAMEBUFFER
    DepthExt = gl.Constants.GL_DEPTH_EXT, 
#endif

#if GL_EXT_DISCARD_FRAMEBUFFER
    StencilExt = gl.Constants.GL_STENCIL_EXT, 
#endif

}

#endif
