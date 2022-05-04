#if (GL_EXT_vertex_weighting && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexWeightfEXT(GLfloat weight);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glVertexWeightfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexWeightfvEXT(GLfloat* weight);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertexWeightfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexWeightPointerEXT(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexWeightPointerTypeEXT, GLsizei, void*, void> glVertexWeightPointerEXT;
#endif
    }
}
#endif