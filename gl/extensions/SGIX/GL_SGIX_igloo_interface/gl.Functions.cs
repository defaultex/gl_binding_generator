#if (GL_SGIX_igloo_interface && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIglooInterfaceSGIX(GLenum pname, void* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void*, void> glIglooInterfaceSGIX;
#endif
    }
}
#endif