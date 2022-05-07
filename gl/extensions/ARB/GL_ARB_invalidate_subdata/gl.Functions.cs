#if (GL_ARB_invalidate_subdata && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glInvalidateBufferData(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void> glInvalidateBufferData;

        /// <summary>void glInvalidateBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void> glInvalidateBufferSubData;

        /// <summary>void glInvalidateFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glInvalidateFramebuffer;

        /// <summary>void glInvalidateSubFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateSubFramebuffer;

        /// <summary>void glInvalidateTexImage(GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, void> glInvalidateTexImage;

        /// <summary>void glInvalidateTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glInvalidateTexSubImage;
    }
}
#endif