#if (GL_NV_instanced_arrays && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glVertexAttribDivisorNV(GLuint index, GLuint divisor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisorNV;
    }
}
#endif