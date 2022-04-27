#if (GL_APPLE_vertex_array_range && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFlushVertexArrayRangeAPPLE(GLsizei length, void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glFlushVertexArrayRangeAPPLE;

        /// <summary>void glVertexArrayParameteriAPPLE(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexArrayPNameAPPLE, GLint, void> glVertexArrayParameteriAPPLE;

        /// <summary>void glVertexArrayRangeAPPLE(GLsizei length, void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glVertexArrayRangeAPPLE;
    }
}
#endif