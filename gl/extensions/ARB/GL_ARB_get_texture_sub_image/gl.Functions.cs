#if (GL_ARB_get_texture_sub_image && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetCompressedTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLsizei, void*, void> glGetCompressedTextureSubImage;

        /// <summary>void glGetTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glGetTextureSubImage;
    }
}
#endif