#if (GL_EXT_draw_elements_base_vertex && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawElementsBaseVertexEXT(GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertexEXT;

        /// <summary>void glDrawElementsInstancedBaseVertexEXT(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertexEXT;

        /// <summary>void glDrawRangeElementsBaseVertexEXT(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertexEXT;

        /// <summary>void glMultiDrawElementsBaseVertexEXT(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount, GLint* basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, GLint*, void> glMultiDrawElementsBaseVertexEXT;
    }
}
#endif