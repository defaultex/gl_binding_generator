#if (GL_OVR_multiview_multisampled_render_to_texture && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glFramebufferTextureMultisampleMultiviewOVR(GLenum target, GLenum attachment, GLuint texture, GLint level, GLsizei samples, GLint baseViewIndex, GLsizei numViews)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLsizei, GLint, GLsizei, void> glFramebufferTextureMultisampleMultiviewOVR;
    }
}
#endif