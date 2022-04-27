#if (GL_EXT_discard_framebuffer && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glDiscardFramebufferEXT(GLenum target, GLsizei numAttachments, const GLenum* attachments)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glDiscardFramebufferEXT;
    }
}
#endif