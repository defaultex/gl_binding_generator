#if (GL_EXT_vertex_weighting && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glVertexWeightPointerEXT(GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, VertexWeightPointerTypeEXT, GLsizei, void*, void> glVertexWeightPointerEXT;

        /// <summary>void glVertexWeightfEXT(GLfloat weight)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glVertexWeightfEXT;

        /// <summary>void glVertexWeightfvEXT(const GLfloat* weight)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glVertexWeightfvEXT;
    }
}
#endif