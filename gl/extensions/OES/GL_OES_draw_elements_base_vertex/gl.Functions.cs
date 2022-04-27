#if (GL_OES_draw_elements_base_vertex && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawElementsBaseVertexOES(GLenum mode, GLsizei count, GLenum type, const void* indices, GLint basevertex)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertexOES;

        /// <summary>void glDrawElementsInstancedBaseVertexOES(GLenum mode, GLsizei count, GLenum type, const void* indices, GLsizei instancecount, GLint basevertex)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertexOES;

        /// <summary>void glDrawRangeElementsBaseVertexOES(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const void* indices, GLint basevertex)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertexOES;

        /// <summary>void glMultiDrawElementsBaseVertexEXT(GLenum mode, const GLsizei* count, GLenum type, const void*const* indices, GLsizei drawcount, const GLint* basevertex)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, GLint*, void> glMultiDrawElementsBaseVertexEXT;
    }
}
#endif