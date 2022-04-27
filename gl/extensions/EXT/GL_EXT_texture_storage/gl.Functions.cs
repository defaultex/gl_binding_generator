#if (GL_EXT_texture_storage && (GLES1_API || GLES2_API || GL_API || GLCORE_API))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glTexStorage1DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, void> glTexStorage1DEXT;

        /// <summary>void glTexStorage2DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2DEXT;

        /// <summary>void glTexStorage3DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTexStorage3DEXT;

        /// <summary>void glTextureStorage1DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLsizei, SizedInternalFormat, GLsizei, void> glTextureStorage1DEXT;

        /// <summary>void glTextureStorage2DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTextureStorage2DEXT;

        /// <summary>void glTextureStorage3DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLenum, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTextureStorage3DEXT;
    }
}
#endif