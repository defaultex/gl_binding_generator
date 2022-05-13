#if GL_NV_vertex_buffer_unified_memory

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint64EXT, GLsizeiptr, void> glBufferAddressRangeNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void> glColorFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void> glEdgeFlagFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glFogCoordFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint64EXT*, void> glGetIntegerui64i_vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glIndexFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glNormalFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void> glSecondaryColorFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void> glTexCoordFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLsizei, void> glVertexAttribFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void> glVertexAttribIFormatNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, void> glVertexFormatNV;
    }
}

#endif