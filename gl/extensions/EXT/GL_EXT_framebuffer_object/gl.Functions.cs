#if (GL_EXT_framebuffer_object && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindFramebufferEXT(GLenum target, GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLframebuffer, void> glBindFramebufferEXT;

        /// <summary>void glBindRenderbufferEXT(GLenum target, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLrenderbuffer, void> glBindRenderbufferEXT;

        /// <summary>GLenum glCheckFramebufferStatusEXT(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLenum> glCheckFramebufferStatusEXT;

        /// <summary>void glDeleteFramebuffersEXT(GLsizei n, const GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glDeleteFramebuffersEXT;

        /// <summary>void glDeleteRenderbuffersEXT(GLsizei n, const GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glDeleteRenderbuffersEXT;

        /// <summary>void glFramebufferRenderbufferEXT(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glFramebufferRenderbufferEXT;

        /// <summary>void glFramebufferTexture1DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture1DEXT;

        /// <summary>void glFramebufferTexture2DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture2DEXT;

        /// <summary>void glFramebufferTexture3DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, GLint, void> glFramebufferTexture3DEXT;

        /// <summary>void glGenFramebuffersEXT(GLsizei n, GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glGenFramebuffersEXT;

        /// <summary>void glGenRenderbuffersEXT(GLsizei n, GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glGenRenderbuffersEXT;

        /// <summary>void glGenerateMipmapEXT(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmapEXT;

        /// <summary>void glGetFramebufferAttachmentParameterivEXT(GLenum target, GLenum attachment, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameterivEXT;

        /// <summary>void glGetRenderbufferParameterivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameterivEXT;

        /// <summary>GLboolean glIsFramebufferEXT(GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLboolean> glIsFramebufferEXT;

        /// <summary>GLboolean glIsRenderbufferEXT(GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLboolean> glIsRenderbufferEXT;

        /// <summary>void glRenderbufferStorageEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageEXT;
    }
}
#endif