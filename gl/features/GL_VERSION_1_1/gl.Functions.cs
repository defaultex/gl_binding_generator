public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBindTexture(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;

        /// <summary>void glCopyTexImage1D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyTexImage1D;

        /// <summary>void glCopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;

        /// <summary>void glCopyTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTexSubImage1D;

        /// <summary>void glCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;

        /// <summary>void glDeleteTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glDeleteTextures;

        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;

        /// <summary>void glDrawElements(GLenum mode, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, ElementType, void*, void> glDrawElements;

        /// <summary>void glGenTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;

        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointerParameter, void**, void> glGetPointerv;

        /// <summary>GLboolean glIsTexture(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLboolean> glIsTexture;

        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;

        /// <summary>void glTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage1D;

        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;
    }
}
