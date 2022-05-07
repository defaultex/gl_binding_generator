#if (GL_ARB_base_instance && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawArraysInstancedBaseInstance(GLenum mode, GLint first, GLsizei count, GLsizei instancecount, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, GLuint, void> glDrawArraysInstancedBaseInstance;

        /// <summary>void glDrawElementsInstancedBaseInstance(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, PrimitiveType, void*, GLsizei, GLuint, void> glDrawElementsInstancedBaseInstance;

        /// <summary>void glDrawElementsInstancedBaseVertexBaseInstance(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, GLuint, void> glDrawElementsInstancedBaseVertexBaseInstance;
    }
}
#endif