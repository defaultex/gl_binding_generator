public partial class gl { 
    public partial class Functions { 

        /// <summary>void glActiveTexture(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;

        /// <summary>void glCompressedTexImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage1D;

        /// <summary>void glCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;

        /// <summary>void glCompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage3D;

        /// <summary>void glCompressedTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage1D;

        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;

        /// <summary>void glCompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage3D;

        /// <summary>void glGetCompressedTexImage(GLenum target, GLint level, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, void*, void> glGetCompressedTexImage;

        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;
    }
}
