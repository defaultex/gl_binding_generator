#if (GL_NV_framebuffer_multisample_coverage && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRenderbufferStorageMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleCoverageNV;
#endif
    }
}
#endif