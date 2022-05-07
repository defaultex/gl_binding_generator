#if (GL_SGIS_texture4D && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTexImage4DSGIS(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage4DSGIS;

        /// <summary>void glTexSubImage4DSGIS(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage4DSGIS;
    }
}
#endif