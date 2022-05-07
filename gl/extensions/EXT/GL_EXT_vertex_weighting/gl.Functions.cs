#if (GL_EXT_vertex_weighting && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glVertexWeightfEXT(GLfloat weight);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glVertexWeightfEXT;

        /// <summary>void glVertexWeightfvEXT(GLfloat* weight);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertexWeightfvEXT;

        /// <summary>void glVertexWeightPointerEXT(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexWeightPointerTypeEXT, GLsizei, void*, void> glVertexWeightPointerEXT;
    }
}
#endif