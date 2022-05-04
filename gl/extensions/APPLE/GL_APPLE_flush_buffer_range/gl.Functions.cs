#if (GL_APPLE_flush_buffer_range && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferParameteriAPPLE(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLint, void> glBufferParameteriAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFlushMappedBufferRangeAPPLE(GLenum target, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRangeAPPLE;
#endif
    }
}
#endif