#if (GL_NV_framebuffer_multisample && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glRenderbufferStorageMultisampleNV(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleNV;
    }
}
#endif