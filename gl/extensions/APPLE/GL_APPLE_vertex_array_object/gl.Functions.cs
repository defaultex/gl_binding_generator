#if (GL_APPLE_vertex_array_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindVertexArrayAPPLE(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, void> glBindVertexArrayAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteVertexArraysAPPLE(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glDeleteVertexArraysAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenVertexArraysAPPLE(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glGenVertexArraysAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsVertexArrayAPPLE(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLboolean> glIsVertexArrayAPPLE;
#endif
    }
}
#endif