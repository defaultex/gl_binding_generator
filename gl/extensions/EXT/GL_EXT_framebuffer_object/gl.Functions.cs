#if (GL_EXT_framebuffer_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindFramebufferEXT(GLenum target, GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, framebuffer, void> glBindFramebufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindRenderbufferEXT(GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, renderbuffer, void> glBindRenderbufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glCheckFramebufferStatusEXT(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferStatus> glCheckFramebufferStatusEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteFramebuffersEXT(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glDeleteFramebuffersEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glDeleteRenderbuffersEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferRenderbufferEXT(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, renderbuffer, void> glFramebufferRenderbufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTexture1DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, void> glFramebufferTexture1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTexture2DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, void> glFramebufferTexture2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTexture3DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, GLint, void> glFramebufferTexture3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenerateMipmapEXT(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmapEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenFramebuffersEXT(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glGenFramebuffersEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glGenRenderbuffersEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFramebufferAttachmentParameterivEXT(GLenum target, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetRenderbufferParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsFramebufferEXT(GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLboolean> glIsFramebufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsRenderbufferEXT(GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, GLboolean> glIsRenderbufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRenderbufferStorageEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageEXT;
#endif
    }
}
#endif