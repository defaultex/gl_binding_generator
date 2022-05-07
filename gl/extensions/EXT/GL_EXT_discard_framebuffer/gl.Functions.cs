#if (GL_EXT_discard_framebuffer && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glDiscardFramebufferEXT(GLenum target, GLsizei numAttachments, GLenum* attachments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glDiscardFramebufferEXT;
    }
}
#endif