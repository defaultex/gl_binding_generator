#if (GL_EXT_stencil_clear_tag && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glStencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint, void> glStencilClearTagEXT;
    }
}
#endif