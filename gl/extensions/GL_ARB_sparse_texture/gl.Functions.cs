#if GL_ARB_sparse_texture

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexPageCommitmentARB;
    }
}

#endif