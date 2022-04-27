#if (GL_OES_framebuffer_object && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glBindFramebufferOES(GLenum target, GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLframebuffer, void> glBindFramebufferOES;

        /// <summary>void glBindRenderbufferOES(GLenum target, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLrenderbuffer, void> glBindRenderbufferOES;

        /// <summary>GLenum glCheckFramebufferStatusOES(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLenum> glCheckFramebufferStatusOES;

        /// <summary>void glDeleteFramebuffersOES(GLsizei n, const GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glDeleteFramebuffersOES;

        /// <summary>void glDeleteRenderbuffersOES(GLsizei n, const GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glDeleteRenderbuffersOES;

        /// <summary>void glFramebufferRenderbufferOES(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glFramebufferRenderbufferOES;

        /// <summary>void glFramebufferTexture2DOES(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture2DOES;

        /// <summary>void glGenFramebuffersOES(GLsizei n, GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glGenFramebuffersOES;

        /// <summary>void glGenRenderbuffersOES(GLsizei n, GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glGenRenderbuffersOES;

        /// <summary>void glGenerateMipmapOES(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmapOES;

        /// <summary>void glGetFramebufferAttachmentParameterivOES(GLenum target, GLenum attachment, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameterivOES;

        /// <summary>void glGetRenderbufferParameterivOES(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameterivOES;

        /// <summary>GLboolean glIsFramebufferOES(GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLboolean> glIsFramebufferOES;

        /// <summary>GLboolean glIsRenderbufferOES(GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLboolean> glIsRenderbufferOES;

        /// <summary>void glRenderbufferStorageOES(GLenum target, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageOES;
    }
}
#endif