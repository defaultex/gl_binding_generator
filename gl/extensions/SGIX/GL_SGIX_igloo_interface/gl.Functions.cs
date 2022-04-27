#if (GL_SGIX_igloo_interface && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glIglooInterfaceSGIX(GLenum pname, const void* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void*, void> glIglooInterfaceSGIX;
    }
}
#endif