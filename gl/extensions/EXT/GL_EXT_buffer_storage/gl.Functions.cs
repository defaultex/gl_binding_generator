#if (GL_EXT_buffer_storage && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBufferStorageEXT(GLenum target, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, GLsizeiptr, void*, BufferStorageMask, void> glBufferStorageEXT;
    }
}
#endif