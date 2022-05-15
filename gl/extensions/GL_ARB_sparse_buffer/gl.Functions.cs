#if GL_ARB_sparse_buffer

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBufferPageCommitmentARB(GLenum target, GLintptr offset, GLsizeiptr size, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLintptr, GLsizeiptr, GLboolean, void> glBufferPageCommitmentARB;

        /// <summary>void glNamedBufferPageCommitmentARB(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, GLboolean, void> glNamedBufferPageCommitmentARB;

        /// <summary>void glNamedBufferPageCommitmentEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, GLboolean, void> glNamedBufferPageCommitmentEXT;
    }
}

#endif