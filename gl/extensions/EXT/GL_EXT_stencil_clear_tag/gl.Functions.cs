#if (GL_EXT_stencil_clear_tag && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint, void> glStencilClearTagEXT;
#endif
    }
}
#endif