#if (GL_NV_texture_barrier && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTextureBarrierNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTextureBarrierNV;
    }
}
#endif