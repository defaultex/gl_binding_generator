#if GL_ARB_instanced_arrays

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glVertexAttribDivisorARB(GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisorARB;
    }
}

#endif