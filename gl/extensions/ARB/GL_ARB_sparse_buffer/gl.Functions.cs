#if (GL_ARB_sparse_buffer && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferPageCommitmentARB(GLenum target, GLintptr offset, GLsizeiptr size, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLintptr, GLsizeiptr, GLboolean, void> glBufferPageCommitmentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferPageCommitmentARB(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, GLboolean, void> glNamedBufferPageCommitmentARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferPageCommitmentEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, GLboolean, void> glNamedBufferPageCommitmentEXT;
#endif
    }
}
#endif