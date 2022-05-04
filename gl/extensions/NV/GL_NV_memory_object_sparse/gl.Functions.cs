#if (GL_NV_memory_object_sparse && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferPageCommitmentMemNV(GLenum target, GLintptr offset, GLsizeiptr size, GLuint memory, GLuint64 memOffset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, GLintptr, GLsizeiptr, GLuint, GLuint64, GLboolean, void> glBufferPageCommitmentMemNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferPageCommitmentMemNV(GLuint buffer, GLintptr offset, GLsizeiptr size, GLuint memory, GLuint64 memOffset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, GLuint, GLuint64, GLboolean, void> glNamedBufferPageCommitmentMemNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexPageCommitmentMemNV(GLenum target, GLint layer, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, GLboolean, void> glTexPageCommitmentMemNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexturePageCommitmentMemNV(GLuint texture, GLint layer, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, GLboolean, void> glTexturePageCommitmentMemNV;
#endif
    }
}
#endif