#if (GL_KHR_blend_equation_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendBarrierKHR();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrierKHR;
#endif
    }
}
#endif