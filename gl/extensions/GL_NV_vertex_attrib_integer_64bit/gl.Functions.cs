#if GL_NV_vertex_attrib_integer_64bit

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint64EXT*, void> glGetVertexAttribLi64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint64EXT*, void> glGetVertexAttribLui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, void> glVertexAttribL1i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL1i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, void> glVertexAttribL1ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL1ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, GLint64EXT, void> glVertexAttribL2i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL2i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint64EXT, void> glVertexAttribL2ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL2ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, GLint64EXT, GLint64EXT, void> glVertexAttribL3i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL3i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glVertexAttribL3ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL3ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, GLint64EXT, GLint64EXT, GLint64EXT, void> glVertexAttribL4i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL4i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glVertexAttribL4ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL4ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLsizei, void> glVertexAttribLFormatNV;
    }
}

#endif