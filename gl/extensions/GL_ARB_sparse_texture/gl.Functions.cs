#if GL_ARB_sparse_texture

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glTexPageCommitmentARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexPageCommitmentARB;
    }
}

#endif