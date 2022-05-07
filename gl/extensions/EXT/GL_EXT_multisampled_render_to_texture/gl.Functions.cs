#if (GL_EXT_multisampled_render_to_texture && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glFramebufferTexture2DMultisampleEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLsizei samples);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, GLsizei, void> glFramebufferTexture2DMultisampleEXT;
    }
}
#endif