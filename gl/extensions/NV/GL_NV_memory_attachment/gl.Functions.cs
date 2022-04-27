#if (GL_NV_memory_attachment && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBufferAttachMemoryNV(GLenum target, GLuint memory, GLuint64 offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLuint64, void> glBufferAttachMemoryNV;

        /// <summary>void glGetMemoryObjectDetachedResourcesuivNV(GLuint memory, GLenum pname, GLint first, GLsizei count, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint, GLsizei, GLuint*, void> glGetMemoryObjectDetachedResourcesuivNV;

        /// <summary>void glNamedBufferAttachMemoryNV(GLuint buffer, GLuint memory, GLuint64 offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLuint, GLuint64, void> glNamedBufferAttachMemoryNV;

        /// <summary>void glResetMemoryObjectParameterNV(GLuint memory, GLenum pname)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glResetMemoryObjectParameterNV;

        /// <summary>void glTexAttachMemoryNV(GLenum target, GLuint memory, GLuint64 offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLuint, GLuint64, void> glTexAttachMemoryNV;

        /// <summary>void glTextureAttachMemoryNV(GLuint texture, GLuint memory, GLuint64 offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint, GLuint64, void> glTextureAttachMemoryNV;
    }
}
#endif