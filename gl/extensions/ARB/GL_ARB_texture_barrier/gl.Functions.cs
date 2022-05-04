#if (GL_ARB_texture_barrier && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureBarrier();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTextureBarrier;
#endif
    }
}
#endif