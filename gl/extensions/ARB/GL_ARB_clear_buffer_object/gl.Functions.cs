#if (GL_ARB_clear_buffer_object && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearBufferData(GLenum target, GLenum internalformat, GLenum format, GLenum type, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearBufferData;

        /// <summary>void glClearBufferSubData(GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, SizedInternalFormat, GLintptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearBufferSubData;
    }
}
#endif