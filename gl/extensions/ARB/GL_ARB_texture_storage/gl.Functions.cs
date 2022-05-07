#if (GL_ARB_texture_storage && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTexStorage1D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, void> glTexStorage1D;

        /// <summary>void glTexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2D;

        /// <summary>void glTexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTexStorage3D;
    }
}
#endif