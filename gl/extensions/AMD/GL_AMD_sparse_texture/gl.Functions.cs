#if (GL_AMD_sparse_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexStorageSparseAMD(GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLsizei, TextureStorageMaskAMD, void> glTexStorageSparseAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorageSparseAMD(GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLenum, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLsizei, TextureStorageMaskAMD, void> glTextureStorageSparseAMD;
#endif
    }
}
#endif