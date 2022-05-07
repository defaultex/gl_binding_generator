#if (GL_ATI_separate_stencil && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glStencilFuncSeparateATI(GLenum frontfunc, GLenum backfunc, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, StencilFunction, GLint, GLuint, void> glStencilFuncSeparateATI;

        /// <summary>void glStencilOpSeparateATI(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparateATI;
    }
}
#endif