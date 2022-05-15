public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBeginQuery(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLquery, void> glBeginQuery;

        /// <summary>void glBindBuffer(GLenum target, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLbuffer, void> glBindBuffer;

        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLsizeiptr, void*, BufferUsage, void> glBufferData;

        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLintptr, GLsizeiptr, void*, void> glBufferSubData;

        /// <summary>void glDeleteBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glDeleteBuffers;

        /// <summary>void glDeleteQueries(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glDeleteQueries;

        /// <summary>void glEndQuery(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQuery;

        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffers;

        /// <summary>void glGenQueries(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glGenQueries;

        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, BufferParameter, GLint*, void> glGetBufferParameteriv;

        /// <summary>void glGetBufferPointerv(GLenum target, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, BufferPointerParameter, void**, void> glGetBufferPointerv;

        /// <summary>void glGetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLintptr, GLsizeiptr, void*, void> glGetBufferSubData;

        /// <summary>void glGetQueryiv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameter, GLint*, void> glGetQueryiv;

        /// <summary>void glGetQueryObjectiv(GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameter, GLint*, void> glGetQueryObjectiv;

        /// <summary>void glGetQueryObjectuiv(GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameter, GLuint*, void> glGetQueryObjectuiv;

        /// <summary>GLboolean glIsBuffer(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsBuffer;

        /// <summary>GLboolean glIsQuery(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLboolean> glIsQuery;

        /// <summary>void* glMapBuffer(GLenum target, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, BufferAccess, void*> glMapBuffer;

        /// <summary>GLboolean glUnmapBuffer(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLboolean> glUnmapBuffer;
    }
}
