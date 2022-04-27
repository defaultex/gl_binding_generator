#if (GL_AMD_stencil_operation_extended && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glStencilOpValueAMD(GLenum face, GLuint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilOpValueAMD;
    }
}
#endif