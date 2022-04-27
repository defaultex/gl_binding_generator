#if (GL_ARB_vertex_array_object && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindVertexArray(GLuint array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, void> glBindVertexArray;

        /// <summary>void glDeleteVertexArrays(GLsizei n, const GLuint* arrays)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glDeleteVertexArrays;

        /// <summary>void glGenVertexArrays(GLsizei n, GLuint* arrays)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glGenVertexArrays;

        /// <summary>GLboolean glIsVertexArray(GLuint array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLboolean> glIsVertexArray;
    }
}
#endif