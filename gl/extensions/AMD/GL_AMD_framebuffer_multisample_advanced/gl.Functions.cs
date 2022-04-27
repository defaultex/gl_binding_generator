#if (GL_AMD_framebuffer_multisample_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glNamedRenderbufferStorageMultisampleAdvancedAMD(GLuint renderbuffer, GLsizei samples, GLsizei storageSamples, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisampleAdvancedAMD;

        /// <summary>void glRenderbufferStorageMultisampleAdvancedAMD(GLenum target, GLsizei samples, GLsizei storageSamples, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleAdvancedAMD;
    }
}
#endif