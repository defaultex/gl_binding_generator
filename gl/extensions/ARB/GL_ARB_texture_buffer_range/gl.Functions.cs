#if (GL_ARB_texture_buffer_range && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTexBufferRange(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, GLintptr, GLsizeiptr, void> glTexBufferRange;
    }
}
#endif