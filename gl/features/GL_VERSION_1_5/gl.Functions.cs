public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLquery, void> glBeginQuery;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLbuffer, void> glBindBuffer;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLsizeiptr, void*, BufferUsage, void> glBufferData;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLintptr, GLsizeiptr, void*, void> glBufferSubData;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glDeleteBuffers;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glDeleteQueries;
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQuery;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffers;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glGenQueries;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, BufferParameter, GLint*, void> glGetBufferParameteriv;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, BufferPointerParameter, void**, void> glGetBufferPointerv;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLintptr, GLsizeiptr, void*, void> glGetBufferSubData;
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameter, GLint*, void> glGetQueryiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameter, GLint*, void> glGetQueryObjectiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameter, GLuint*, void> glGetQueryObjectuiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsBuffer;
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLboolean> glIsQuery;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, BufferAccess, void*> glMapBuffer;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLboolean> glUnmapBuffer;
    }
}
