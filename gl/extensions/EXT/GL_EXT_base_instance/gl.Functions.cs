#if (GL_EXT_base_instance && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawArraysInstancedBaseInstanceEXT(GLenum mode, GLint first, GLsizei count, GLsizei instancecount, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, GLuint, void> glDrawArraysInstancedBaseInstanceEXT;

        /// <summary>void glDrawElementsInstancedBaseInstanceEXT(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, PrimitiveType, void*, GLsizei, GLuint, void> glDrawElementsInstancedBaseInstanceEXT;

        /// <summary>void glDrawElementsInstancedBaseVertexBaseInstanceEXT(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex, GLuint baseinstance);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, GLuint, void> glDrawElementsInstancedBaseVertexBaseInstanceEXT;
    }
}
#endif