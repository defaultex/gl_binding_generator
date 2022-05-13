#if GL_NV_memory_object_sparse

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, GLintptr, GLsizeiptr, GLuint, GLuint64, GLboolean, void> glBufferPageCommitmentMemNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, GLuint, GLuint64, GLboolean, void> glNamedBufferPageCommitmentMemNV;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, GLboolean, void> glTexPageCommitmentMemNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, GLboolean, void> glTexturePageCommitmentMemNV;
    }
}

#endif