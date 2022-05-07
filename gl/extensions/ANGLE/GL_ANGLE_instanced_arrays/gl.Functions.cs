#if (GL_ANGLE_instanced_arrays && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawArraysInstancedANGLE(GLenum mode, GLint first, GLsizei count, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstancedANGLE;

        /// <summary>void glDrawElementsInstancedANGLE(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, PrimitiveType, void*, GLsizei, void> glDrawElementsInstancedANGLE;

        /// <summary>void glVertexAttribDivisorANGLE(GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisorANGLE;
    }
}
#endif