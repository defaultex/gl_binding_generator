#if (GL_ARB_vertex_buffer_object && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindBufferARB(GLenum target, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLbuffer, void> glBindBufferARB;

        /// <summary>void glBufferDataARB(GLenum target, GLsizeiptrARB size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptrARB, void*, BufferUsageARB, void> glBufferDataARB;

        /// <summary>void glBufferSubDataARB(GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptrARB, GLsizeiptrARB, void*, void> glBufferSubDataARB;

        /// <summary>void glDeleteBuffersARB(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glDeleteBuffersARB;

        /// <summary>void glGenBuffersARB(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffersARB;

        /// <summary>void glGetBufferParameterivARB(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameterivARB;

        /// <summary>void glGetBufferPointervARB(GLenum target, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPointerNameARB, void**, void> glGetBufferPointervARB;

        /// <summary>void glGetBufferSubDataARB(GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptrARB, GLsizeiptrARB, void*, void> glGetBufferSubDataARB;

        /// <summary>GLboolean glIsBufferARB(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsBufferARB;

        /// <summary>void* glMapBufferARB(GLenum target, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferAccessARB, void*> glMapBufferARB;

        /// <summary>GLboolean glUnmapBufferARB(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLboolean> glUnmapBufferARB;
    }
}
#endif