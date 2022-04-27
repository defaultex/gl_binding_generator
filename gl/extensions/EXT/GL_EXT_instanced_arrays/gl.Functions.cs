#if (GL_EXT_instanced_arrays && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawArraysInstancedEXT(GLenum mode, GLint start, GLsizei count, GLsizei primcount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstancedEXT;

        /// <summary>void glDrawElementsInstancedEXT(GLenum mode, GLsizei count, GLenum type, const void* indices, GLsizei primcount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, void> glDrawElementsInstancedEXT;

        /// <summary>void glVertexAttribDivisorEXT(GLuint index, GLuint divisor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisorEXT;
    }
}
#endif