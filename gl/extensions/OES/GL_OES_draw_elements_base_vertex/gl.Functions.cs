#if (GL_OES_draw_elements_base_vertex && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawElementsBaseVertexOES(GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertexOES;

        /// <summary>void glDrawElementsInstancedBaseVertexOES(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertexOES;

        /// <summary>void glDrawRangeElementsBaseVertexOES(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertexOES;
    }
}
#endif