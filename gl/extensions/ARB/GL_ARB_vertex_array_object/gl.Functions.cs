#if (GL_ARB_vertex_array_object && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindVertexArray(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, void> glBindVertexArray;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDeleteVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glDeleteVertexArrays;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGenVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glGenVertexArrays;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsVertexArray(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLboolean> glIsVertexArray;
#endif
    }
}
#endif