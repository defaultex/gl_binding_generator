#if (GL_EXT_texture_buffer && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glTexBufferEXT(GLenum target, GLenum internalformat, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, void> glTexBufferEXT;

        /// <summary>void glTexBufferRangeEXT(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, GLintptr, GLsizeiptr, void> glTexBufferRangeEXT;
    }
}
#endif