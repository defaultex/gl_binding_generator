#if (GL_AMD_stencil_operation_extended && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilOpValueAMD(GLenum face, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilOpValueAMD;
#endif
    }
}
#endif