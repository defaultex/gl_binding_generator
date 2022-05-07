#if (GL_ARB_map_buffer_range && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRange;

        /// <summary>void* glMapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapBufferRange;
    }
}
#endif