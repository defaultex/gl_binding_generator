#if (GL_ARB_texture_compression && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCompressedTexImage1DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage1DARB;

        /// <summary>void glCompressedTexImage2DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2DARB;

        /// <summary>void glCompressedTexImage3DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage3DARB;

        /// <summary>void glCompressedTexSubImage1DARB(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage1DARB;

        /// <summary>void glCompressedTexSubImage2DARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2DARB;

        /// <summary>void glCompressedTexSubImage3DARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage3DARB;

        /// <summary>void glGetCompressedTexImageARB(GLenum target, GLint level, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, void*, void> glGetCompressedTexImageARB;
    }
}
#endif