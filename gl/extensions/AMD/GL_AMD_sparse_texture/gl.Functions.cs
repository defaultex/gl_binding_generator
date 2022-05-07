#if (GL_AMD_sparse_texture && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTexStorageSparseAMD(GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLsizei, TextureStorageMaskAMD, void> glTexStorageSparseAMD;

        /// <summary>void glTextureStorageSparseAMD(GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLsizei, TextureStorageMaskAMD, void> glTextureStorageSparseAMD;
    }
}
#endif