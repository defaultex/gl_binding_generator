#if (GL_ARB_buffer_storage && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBufferStorage(GLenum target, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, GLsizeiptr, void*, BufferStorageMask, void> glBufferStorage;
    }
}
#endif