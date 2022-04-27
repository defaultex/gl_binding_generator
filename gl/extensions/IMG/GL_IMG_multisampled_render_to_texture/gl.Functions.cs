#if (GL_IMG_multisampled_render_to_texture && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glFramebufferTexture2DMultisampleIMG(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLsizei samples)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, GLsizei, void> glFramebufferTexture2DMultisampleIMG;

        /// <summary>void glRenderbufferStorageMultisampleIMG(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleIMG;
    }
}
#endif