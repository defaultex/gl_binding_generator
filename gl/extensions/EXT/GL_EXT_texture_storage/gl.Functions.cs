#if (GL_EXT_texture_storage && (!gles1 || !gles2 || !gl || !glcore))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glTexStorage1DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, void> glTexStorage1DEXT;

        /// <summary>void glTexStorage2DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2DEXT;

        /// <summary>void glTexStorage3DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTexStorage3DEXT;
    }
}
#endif