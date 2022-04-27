#if (GL_NV_scissor_exclusive && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glScissorExclusiveArrayvNV(GLuint first, GLsizei count, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorExclusiveArrayvNV;

        /// <summary>void glScissorExclusiveNV(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissorExclusiveNV;
    }
}
#endif