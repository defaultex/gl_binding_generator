#if (GL_INTEL_framebuffer_CMAA && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glApplyFramebufferAttachmentCMAAINTEL()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glApplyFramebufferAttachmentCMAAINTEL;
    }
}
#endif