#if (GL_NV_memory_object_sparse && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBufferPageCommitmentMemNV(GLenum target, GLintptr offset, GLsizeiptr size, GLuint memory, GLuint64 memOffset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, GLintptr, GLsizeiptr, GLuint, GLuint64, GLboolean, void> glBufferPageCommitmentMemNV;

        /// <summary>void glNamedBufferPageCommitmentMemNV(GLuint buffer, GLintptr offset, GLsizeiptr size, GLuint memory, GLuint64 memOffset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, GLuint, GLuint64, GLboolean, void> glNamedBufferPageCommitmentMemNV;

        /// <summary>void glTexPageCommitmentMemNV(GLenum target, GLint layer, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, GLboolean, void> glTexPageCommitmentMemNV;

        /// <summary>void glTexturePageCommitmentMemNV(GLuint texture, GLint layer, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, GLboolean, void> glTexturePageCommitmentMemNV;
    }
}
#endif