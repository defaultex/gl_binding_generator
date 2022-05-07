#if (GL_ARB_vertex_blend && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glVertexBlendARB(GLint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glVertexBlendARB;

        /// <summary>void glWeightbvARB(GLint size, GLbyte* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLbyte*, void> glWeightbvARB;

        /// <summary>void glWeightdvARB(GLint size, GLdouble* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble*, void> glWeightdvARB;

        /// <summary>void glWeightfvARB(GLint size, GLfloat* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat*, void> glWeightfvARB;

        /// <summary>void glWeightivARB(GLint size, GLint* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint*, void> glWeightivARB;

        /// <summary>void glWeightPointerARB(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, WeightPointerTypeARB, GLsizei, void*, void> glWeightPointerARB;

        /// <summary>void glWeightsvARB(GLint size, GLshort* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLshort*, void> glWeightsvARB;

        /// <summary>void glWeightubvARB(GLint size, GLubyte* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLubyte*, void> glWeightubvARB;

        /// <summary>void glWeightuivARB(GLint size, GLuint* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint*, void> glWeightuivARB;

        /// <summary>void glWeightusvARB(GLint size, GLushort* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLushort*, void> glWeightusvARB;
    }
}
#endif