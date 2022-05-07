#if (GL_EXT_sparse_texture && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glTexPageCommitmentEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexPageCommitmentEXT;
    }
}
#endif