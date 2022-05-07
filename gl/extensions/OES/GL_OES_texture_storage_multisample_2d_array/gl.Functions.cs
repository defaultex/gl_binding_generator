#if (GL_OES_texture_storage_multisample_2d_array && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glTexStorage3DMultisampleOES(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexStorage3DMultisampleOES;
    }
}
#endif