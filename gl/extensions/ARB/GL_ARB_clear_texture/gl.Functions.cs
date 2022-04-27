#if (GL_ARB_clear_texture && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearTexImage(GLuint texture, GLint level, GLenum format, GLenum type, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, PixelFormat, PixelType, void*, void> glClearTexImage;

        /// <summary>void glClearTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glClearTexSubImage;
    }
}
#endif