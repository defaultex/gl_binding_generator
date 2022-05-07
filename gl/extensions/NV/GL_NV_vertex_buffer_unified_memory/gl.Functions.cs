#if (GL_NV_vertex_buffer_unified_memory && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBufferAddressRangeNV(GLenum pname, GLuint index, GLuint64EXT address, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint64EXT, GLsizeiptr, void> glBufferAddressRangeNV;

        /// <summary>void glColorFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void> glColorFormatNV;

        /// <summary>void glEdgeFlagFormatNV(GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void> glEdgeFlagFormatNV;

        /// <summary>void glFogCoordFormatNV(GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glFogCoordFormatNV;

        /// <summary>void glGetIntegerui64i_vNV(GLenum value, GLuint index, GLuint64EXT* result);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint64EXT*, void> glGetIntegerui64i_vNV;

        /// <summary>void glIndexFormatNV(GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glIndexFormatNV;

        /// <summary>void glNormalFormatNV(GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glNormalFormatNV;

        /// <summary>void glSecondaryColorFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void> glSecondaryColorFormatNV;

        /// <summary>void glTexCoordFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void> glTexCoordFormatNV;

        /// <summary>void glVertexAttribFormatNV(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLsizei, void> glVertexAttribFormatNV;

        /// <summary>void glVertexAttribIFormatNV(GLuint index, GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void> glVertexAttribIFormatNV;

        /// <summary>void glVertexFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, void> glVertexFormatNV;
    }
}
#endif