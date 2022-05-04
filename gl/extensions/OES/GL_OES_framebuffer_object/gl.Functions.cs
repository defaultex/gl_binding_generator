#if (GL_OES_framebuffer_object && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindFramebufferOES(GLenum target, GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, framebuffer, void> glBindFramebufferOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindRenderbufferOES(GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, renderbuffer, void> glBindRenderbufferOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glCheckFramebufferStatusOES(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferStatus> glCheckFramebufferStatusOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteFramebuffersOES(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glDeleteFramebuffersOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteRenderbuffersOES(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glDeleteRenderbuffersOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferRenderbufferOES(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, renderbuffer, void> glFramebufferRenderbufferOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTexture2DOES(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, void> glFramebufferTexture2DOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenerateMipmapOES(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmapOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenFramebuffersOES(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glGenFramebuffersOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenRenderbuffersOES(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glGenRenderbuffersOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFramebufferAttachmentParameterivOES(GLenum target, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameterivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetRenderbufferParameterivOES(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameterivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsFramebufferOES(GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLboolean> glIsFramebufferOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsRenderbufferOES(GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, GLboolean> glIsRenderbufferOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRenderbufferStorageOES(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageOES;
#endif
    }
}
#endif