#if (GL_EXT_texture_buffer_object && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTexBufferEXT(GLenum target, GLenum internalformat, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, void> glTexBufferEXT;
    }
}
#endif