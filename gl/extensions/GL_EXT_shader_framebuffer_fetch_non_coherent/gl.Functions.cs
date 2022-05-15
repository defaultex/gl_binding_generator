#if GL_EXT_shader_framebuffer_fetch_non_coherent

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glFramebufferFetchBarrierEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFramebufferFetchBarrierEXT;
    }
}

#endif