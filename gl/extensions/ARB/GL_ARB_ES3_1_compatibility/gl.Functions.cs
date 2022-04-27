#if (GL_ARB_ES3_1_compatibility && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMemoryBarrierByRegion(GLbitfield barriers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrierByRegion;
    }
}
#endif