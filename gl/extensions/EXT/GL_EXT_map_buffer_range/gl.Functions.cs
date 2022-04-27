#if (GL_EXT_map_buffer_range && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glFlushMappedBufferRangeEXT(GLenum target, GLintptr offset, GLsizeiptr length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRangeEXT;

        /// <summary>void* glMapBufferRangeEXT(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapBufferRangeEXT;
    }
}
#endif