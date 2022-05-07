#if (GL_EXT_framebuffer_multisample && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glRenderbufferStorageMultisampleEXT(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleEXT;
    }
}
#endif