#if (GL_INTEL_framebuffer_CMAA && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glApplyFramebufferAttachmentCMAAINTEL();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glApplyFramebufferAttachmentCMAAINTEL;
#endif
    }
}
#endif