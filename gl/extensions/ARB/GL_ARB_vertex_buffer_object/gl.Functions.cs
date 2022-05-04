#if (GL_ARB_vertex_buffer_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindBufferARB(GLenum target, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, buffer, void> glBindBufferARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferDataARB(GLenum target, GLsizeiptrARB size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptrARB, void*, BufferUsageARB, void> glBufferDataARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferSubDataARB(GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptrARB, GLsizeiptrARB, void*, void> glBufferSubDataARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteBuffersARB(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, buffer*, void> glDeleteBuffersARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenBuffersARB(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, buffer*, void> glGenBuffersARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetBufferParameterivARB(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameterivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetBufferPointervARB(GLenum target, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPointerNameARB, void**, void> glGetBufferPointervARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetBufferSubDataARB(GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptrARB, GLsizeiptrARB, void*, void> glGetBufferSubDataARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsBufferARB(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLboolean> glIsBufferARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void* glMapBufferARB(GLenum target, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferAccessARB, void*> glMapBufferARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glUnmapBufferARB(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLboolean> glUnmapBufferARB;
#endif
    }
}
#endif