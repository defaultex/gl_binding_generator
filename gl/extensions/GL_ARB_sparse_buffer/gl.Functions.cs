#if GL_ARB_sparse_buffer

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLintptr, GLsizeiptr, GLboolean, void> glBufferPageCommitmentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, GLboolean, void> glNamedBufferPageCommitmentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, GLboolean, void> glNamedBufferPageCommitmentEXT;
    }
}

#endif