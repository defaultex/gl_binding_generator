#if (GL_ARB_vertex_blend && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glVertexBlendARB(GLint count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glVertexBlendARB;

        /// <summary>void glWeightPointerARB(GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, WeightPointerTypeARB, GLsizei, void*, void> glWeightPointerARB;

        /// <summary>void glWeightbvARB(GLint size, const GLbyte* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLbyte*, void> glWeightbvARB;

        /// <summary>void glWeightdvARB(GLint size, const GLdouble* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble*, void> glWeightdvARB;

        /// <summary>void glWeightfvARB(GLint size, const GLfloat* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat*, void> glWeightfvARB;

        /// <summary>void glWeightivARB(GLint size, const GLint* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint*, void> glWeightivARB;

        /// <summary>void glWeightsvARB(GLint size, const GLshort* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLshort*, void> glWeightsvARB;

        /// <summary>void glWeightubvARB(GLint size, const GLubyte* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLubyte*, void> glWeightubvARB;

        /// <summary>void glWeightuivARB(GLint size, const GLuint* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint*, void> glWeightuivARB;

        /// <summary>void glWeightusvARB(GLint size, const GLushort* weights)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLushort*, void> glWeightusvARB;
    }
}
#endif