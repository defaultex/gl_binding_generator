#if (GL_EXT_shader_framebuffer_fetch_non_coherent && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferFetchBarrierEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFramebufferFetchBarrierEXT;
#endif
    }
}
#endif