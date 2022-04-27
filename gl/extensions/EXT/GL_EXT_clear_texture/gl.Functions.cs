#if (GL_EXT_clear_texture && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glClearTexImageEXT(GLuint texture, GLint level, GLenum format, GLenum type, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, PixelFormat, PixelType, void*, void> glClearTexImageEXT;

        /// <summary>void glClearTexSubImageEXT(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glClearTexSubImageEXT;
    }
}
#endif