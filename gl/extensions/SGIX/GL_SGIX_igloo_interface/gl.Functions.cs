#if (GL_SGIX_igloo_interface && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glIglooInterfaceSGIX(GLenum pname, void* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void*, void> glIglooInterfaceSGIX;
    }
}
#endif