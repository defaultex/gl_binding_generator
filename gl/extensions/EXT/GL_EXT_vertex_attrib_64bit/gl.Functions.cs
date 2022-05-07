#if (GL_EXT_vertex_attrib_64bit && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetVertexAttribLdvEXT(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLdouble*, void> glGetVertexAttribLdvEXT;

        /// <summary>void glVertexAttribL1dEXT(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttribL1dEXT;

        /// <summary>void glVertexAttribL1dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL1dvEXT;

        /// <summary>void glVertexAttribL2dEXT(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttribL2dEXT;

        /// <summary>void glVertexAttribL2dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL2dvEXT;

        /// <summary>void glVertexAttribL3dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttribL3dEXT;

        /// <summary>void glVertexAttribL3dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL3dvEXT;

        /// <summary>void glVertexAttribL4dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttribL4dEXT;

        /// <summary>void glVertexAttribL4dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL4dvEXT;

        /// <summary>void glVertexAttribLPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLsizei, void*, void> glVertexAttribLPointerEXT;
    }
}
#endif