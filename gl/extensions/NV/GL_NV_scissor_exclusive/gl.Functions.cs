#if (GL_NV_scissor_exclusive && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glScissorExclusiveArrayvNV(GLuint first, GLsizei count, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorExclusiveArrayvNV;

        /// <summary>void glScissorExclusiveNV(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissorExclusiveNV;
    }
}
#endif