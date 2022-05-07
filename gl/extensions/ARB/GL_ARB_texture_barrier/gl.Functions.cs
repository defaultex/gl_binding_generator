#if (GL_ARB_texture_barrier && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTextureBarrier();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTextureBarrier;
    }
}
#endif