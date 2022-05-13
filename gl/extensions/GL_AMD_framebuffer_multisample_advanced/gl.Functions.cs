#if GL_AMD_framebuffer_multisample_advanced

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisampleAdvancedAMD;
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleAdvancedAMD;
    }
}

#endif