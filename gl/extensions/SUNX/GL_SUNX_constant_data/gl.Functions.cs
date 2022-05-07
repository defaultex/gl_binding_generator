#if (GL_SUNX_constant_data && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFinishTextureSUNX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinishTextureSUNX;
    }
}
#endif