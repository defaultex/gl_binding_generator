#if (GL_APPLE_flush_buffer_range && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBufferParameteriAPPLE(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLint, void> glBufferParameteriAPPLE;

        /// <summary>void glFlushMappedBufferRangeAPPLE(GLenum target, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRangeAPPLE;
    }
}
#endif