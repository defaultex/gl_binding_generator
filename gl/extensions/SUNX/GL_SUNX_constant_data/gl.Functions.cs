#if (GL_SUNX_constant_data && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFinishTextureSUNX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinishTextureSUNX;
#endif
    }
}
#endif