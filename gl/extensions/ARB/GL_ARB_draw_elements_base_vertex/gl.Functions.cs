#if (GL_ARB_draw_elements_base_vertex && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertex;

        /// <summary>void glDrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertex;

        /// <summary>void glDrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertex;

        /// <summary>void glMultiDrawElementsBaseVertex(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount, GLint* basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, GLint*, void> glMultiDrawElementsBaseVertex;
    }
}
#endif