#if GL_NV_texture_barrier

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glTextureBarrierNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTextureBarrierNV;
    }
}

#endif