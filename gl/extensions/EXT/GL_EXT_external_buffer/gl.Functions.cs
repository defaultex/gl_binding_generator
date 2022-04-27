#if (GL_EXT_external_buffer && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBufferStorageExternalEXT(GLenum target, GLintptr offset, GLsizeiptr size, GLeglClientBufferEXT clientBuffer, GLbitfield flags)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLintptr, GLsizeiptr, GLeglClientBufferEXT, BufferStorageMask, void> glBufferStorageExternalEXT;

        /// <summary>void glNamedBufferStorageExternalEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, GLeglClientBufferEXT clientBuffer, GLbitfield flags)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, GLeglClientBufferEXT, BufferStorageMask, void> glNamedBufferStorageExternalEXT;
    }
}
#endif