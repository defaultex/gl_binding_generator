#if (GL_ANGLE_framebuffer_multisample && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glRenderbufferStorageMultisampleANGLE(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleANGLE;
    }
}
#endif