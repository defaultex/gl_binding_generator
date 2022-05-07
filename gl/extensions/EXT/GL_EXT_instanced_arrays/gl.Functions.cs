#if (GL_EXT_instanced_arrays && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glVertexAttribDivisorEXT(GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisorEXT;
    }
}
#endif