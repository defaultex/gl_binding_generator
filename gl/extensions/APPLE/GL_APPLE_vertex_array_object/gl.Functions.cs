#if (GL_APPLE_vertex_array_object && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindVertexArrayAPPLE(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, void> glBindVertexArrayAPPLE;

        /// <summary>void glDeleteVertexArraysAPPLE(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glDeleteVertexArraysAPPLE;

        /// <summary>void glGenVertexArraysAPPLE(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glGenVertexArraysAPPLE;

        /// <summary>GLboolean glIsVertexArrayAPPLE(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLboolean> glIsVertexArrayAPPLE;
    }
}
#endif