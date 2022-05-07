#if (GL_ARB_texture_buffer_object && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTexBufferARB(GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, void> glTexBufferARB;
    }
}
#endif