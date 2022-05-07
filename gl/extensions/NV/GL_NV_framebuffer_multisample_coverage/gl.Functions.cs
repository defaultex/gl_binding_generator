#if (GL_NV_framebuffer_multisample_coverage && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glRenderbufferStorageMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleCoverageNV;
    }
}
#endif