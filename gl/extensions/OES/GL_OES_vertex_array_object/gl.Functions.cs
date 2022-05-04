#if (GL_OES_vertex_array_object && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindVertexArrayOES(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, void> glBindVertexArrayOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteVertexArraysOES(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glDeleteVertexArraysOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenVertexArraysOES(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glGenVertexArraysOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsVertexArrayOES(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLboolean> glIsVertexArrayOES;
#endif
    }
}
#endif