#if GL_NV_scissor_exclusive

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorExclusiveArrayvNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissorExclusiveNV;
    }
}

#endif