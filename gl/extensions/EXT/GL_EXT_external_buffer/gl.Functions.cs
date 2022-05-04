#if (GL_EXT_external_buffer && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferStorageExternalEXT(GLenum target, GLintptr offset, GLsizeiptr size, GLeglClientBufferEXT clientBuffer, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLintptr, GLsizeiptr, GLeglClientBufferEXT, BufferStorageMask, void> glBufferStorageExternalEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferStorageExternalEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, GLeglClientBufferEXT clientBuffer, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, GLeglClientBufferEXT, BufferStorageMask, void> glNamedBufferStorageExternalEXT;
#endif
    }
}
#endif