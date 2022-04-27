#if (GL_NV_framebuffer_blit && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBlitFramebufferNV(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, BlitFramebufferFilter, void> glBlitFramebufferNV;
    }
}
#endif