#if (GL_ARB_clear_buffer_object && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearBufferData(GLenum target, GLenum internalformat, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearBufferData;

        /// <summary>void glClearBufferSubData(GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, SizedInternalFormat, GLintptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearBufferSubData;
    }
}
#endif