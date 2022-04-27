#if (GL_EXT_stencil_two_side && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glActiveStencilFaceEXT(GLenum face)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, void> glActiveStencilFaceEXT;
    }
}
#endif