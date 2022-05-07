#if (GL_APPLE_framebuffer_multisample && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glRenderbufferStorageMultisampleAPPLE(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleAPPLE;

        /// <summary>void glResolveMultisampleFramebufferAPPLE();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResolveMultisampleFramebufferAPPLE;
    }
}
#endif