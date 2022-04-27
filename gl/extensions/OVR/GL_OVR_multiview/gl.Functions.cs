#if (GL_OVR_multiview && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFramebufferTextureMultiviewOVR(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint baseViewIndex, GLsizei numViews)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, GLsizei, void> glFramebufferTextureMultiviewOVR;
    }
}
#endif