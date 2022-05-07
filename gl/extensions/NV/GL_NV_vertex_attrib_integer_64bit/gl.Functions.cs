#if (GL_NV_vertex_attrib_integer_64bit && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetVertexAttribLi64vNV(GLuint index, GLenum pname, GLint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint64EXT*, void> glGetVertexAttribLi64vNV;

        /// <summary>void glGetVertexAttribLui64vNV(GLuint index, GLenum pname, GLuint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint64EXT*, void> glGetVertexAttribLui64vNV;

        /// <summary>void glVertexAttribL1i64NV(GLuint index, GLint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, void> glVertexAttribL1i64NV;

        /// <summary>void glVertexAttribL1i64vNV(GLuint index, GLint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL1i64vNV;

        /// <summary>void glVertexAttribL1ui64NV(GLuint index, GLuint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, void> glVertexAttribL1ui64NV;

        /// <summary>void glVertexAttribL1ui64vNV(GLuint index, GLuint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL1ui64vNV;

        /// <summary>void glVertexAttribL2i64NV(GLuint index, GLint64EXT x, GLint64EXT y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, GLint64EXT, void> glVertexAttribL2i64NV;

        /// <summary>void glVertexAttribL2i64vNV(GLuint index, GLint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL2i64vNV;

        /// <summary>void glVertexAttribL2ui64NV(GLuint index, GLuint64EXT x, GLuint64EXT y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint64EXT, void> glVertexAttribL2ui64NV;

        /// <summary>void glVertexAttribL2ui64vNV(GLuint index, GLuint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL2ui64vNV;

        /// <summary>void glVertexAttribL3i64NV(GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, GLint64EXT, GLint64EXT, void> glVertexAttribL3i64NV;

        /// <summary>void glVertexAttribL3i64vNV(GLuint index, GLint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL3i64vNV;

        /// <summary>void glVertexAttribL3ui64NV(GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glVertexAttribL3ui64NV;

        /// <summary>void glVertexAttribL3ui64vNV(GLuint index, GLuint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL3ui64vNV;

        /// <summary>void glVertexAttribL4i64NV(GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT, GLint64EXT, GLint64EXT, GLint64EXT, void> glVertexAttribL4i64NV;

        /// <summary>void glVertexAttribL4i64vNV(GLuint index, GLint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint64EXT*, void> glVertexAttribL4i64vNV;

        /// <summary>void glVertexAttribL4ui64NV(GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glVertexAttribL4ui64NV;

        /// <summary>void glVertexAttribL4ui64vNV(GLuint index, GLuint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL4ui64vNV;

        /// <summary>void glVertexAttribLFormatNV(GLuint index, GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLsizei, void> glVertexAttribLFormatNV;
    }
}
#endif