#if (GL_EXT_texture_buffer_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexBufferEXT(GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, buffer, void> glTexBufferEXT;
#endif
    }
}
#endif