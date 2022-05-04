#if (GL_NV_scissor_exclusive && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorExclusiveArrayvNV(GLuint first, GLsizei count, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorExclusiveArrayvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorExclusiveNV(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissorExclusiveNV;
#endif
    }
}
#endif