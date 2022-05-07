#if (GL_OES_vertex_array_object && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glBindVertexArrayOES(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, void> glBindVertexArrayOES;

        /// <summary>void glDeleteVertexArraysOES(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glDeleteVertexArraysOES;

        /// <summary>void glGenVertexArraysOES(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glGenVertexArraysOES;

        /// <summary>GLboolean glIsVertexArrayOES(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLboolean> glIsVertexArrayOES;
    }
}
#endif