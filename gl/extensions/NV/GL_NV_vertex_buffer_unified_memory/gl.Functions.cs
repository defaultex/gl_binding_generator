#if (GL_NV_vertex_buffer_unified_memory && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferAddressRangeNV(GLenum pname, GLuint index, GLuint64EXT address, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint64EXT, GLsizeiptr, void> glBufferAddressRangeNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void> glColorFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEdgeFlagFormatNV(GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void> glEdgeFlagFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoordFormatNV(GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glFogCoordFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetIntegerui64i_vNV(GLenum value, GLuint index, GLuint64EXT* result);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint64EXT*, void> glGetIntegerui64i_vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIndexFormatNV(GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glIndexFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormalFormatNV(GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, void> glNormalFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColorFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void> glSecondaryColorFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoordFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum, GLsizei, void> glTexCoordFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribFormatNV(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLsizei, void> glVertexAttribFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribIFormatNV(GLuint index, GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void> glVertexAttribIFormatNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexFormatNV(GLint size, GLenum type, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexPointerType, GLsizei, void> glVertexFormatNV;
#endif
    }
}
#endif