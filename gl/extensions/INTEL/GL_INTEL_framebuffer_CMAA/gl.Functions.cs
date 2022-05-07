#if (GL_INTEL_framebuffer_CMAA && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glApplyFramebufferAttachmentCMAAINTEL();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glApplyFramebufferAttachmentCMAAINTEL;
    }
}
#endif