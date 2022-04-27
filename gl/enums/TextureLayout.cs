#if GL_EXT_SEMAPHORE

public enum TextureLayout : GLenum { 
#if GL_EXT_SEMAPHORE
    LayoutDepthReadOnlyStencilAttachmentExt = gl.Constants.GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutDepthAttachmentStencilReadOnlyExt = gl.Constants.GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutGeneralExt = gl.Constants.GL_LAYOUT_GENERAL_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutColorAttachmentExt = gl.Constants.GL_LAYOUT_COLOR_ATTACHMENT_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutDepthStencilAttachmentExt = gl.Constants.GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutDepthStencilReadOnlyExt = gl.Constants.GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutShaderReadOnlyExt = gl.Constants.GL_LAYOUT_SHADER_READ_ONLY_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutTransferSrcExt = gl.Constants.GL_LAYOUT_TRANSFER_SRC_EXT, 
#endif

#if GL_EXT_SEMAPHORE
    LayoutTransferDstExt = gl.Constants.GL_LAYOUT_TRANSFER_DST_EXT, 
#endif

}

#endif
