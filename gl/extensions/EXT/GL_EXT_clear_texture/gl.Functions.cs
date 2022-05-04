#if (GL_EXT_clear_texture && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearTexImageEXT(GLuint texture, GLint level, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, PixelFormat, PixelType, void*, void> glClearTexImageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearTexSubImageEXT(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glClearTexSubImageEXT;
#endif
    }
}
#endif