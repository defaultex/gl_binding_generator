#if (GL_QCOM_shader_framebuffer_fetch_noncoherent && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glFramebufferFetchBarrierQCOM();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFramebufferFetchBarrierQCOM;
    }
}
#endif