#if (GL_NV_texture_barrier && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureBarrierNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTextureBarrierNV;
#endif
    }
}
#endif