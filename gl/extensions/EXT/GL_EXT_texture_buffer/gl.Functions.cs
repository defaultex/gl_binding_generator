#if (GL_EXT_texture_buffer && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexBufferEXT(GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, buffer, void> glTexBufferEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexBufferRangeEXT(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, buffer, GLintptr, GLsizeiptr, void> glTexBufferRangeEXT;
#endif
    }
}
#endif