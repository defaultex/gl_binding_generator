#if GL_NV_framebuffer_multisample_coverage

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleCoverageNV;
    }
}

#endif