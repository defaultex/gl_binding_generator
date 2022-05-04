#if (GL_VERSION_1_5 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBeginQuery(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, query, void> glBeginQuery;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindBuffer(GLenum target, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, buffer, void> glBindBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, void*, BufferUsageARB, void> glBufferData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glBufferSubData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, buffer*, void> glDeleteBuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteQueries(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glDeleteQueries;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEndQuery(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQuery;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, buffer*, void> glGenBuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenQueries(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glGenQueries;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBufferPointerv(GLenum target, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPointerNameARB, void**, void> glGetBufferPointerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glGetBufferSubData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryiv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryObjectiv(GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLint*, void> glGetQueryObjectiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryObjectuiv(GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsBuffer(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLboolean> glIsBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsQuery(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, GLboolean> glIsQuery;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void* glMapBuffer(GLenum target, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferAccessARB, void*> glMapBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glUnmapBuffer(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLboolean> glUnmapBuffer;
#endif
    }
}
#endif