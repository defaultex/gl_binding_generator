#if (GL_ARB_vertex_attrib_64bit && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetVertexAttribLdv(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLdouble*, void> glGetVertexAttribLdv;

        /// <summary>void glVertexAttribL1d(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttribL1d;

        /// <summary>void glVertexAttribL1dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL1dv;

        /// <summary>void glVertexAttribL2d(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttribL2d;

        /// <summary>void glVertexAttribL2dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL2dv;

        /// <summary>void glVertexAttribL3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttribL3d;

        /// <summary>void glVertexAttribL3dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL3dv;

        /// <summary>void glVertexAttribL4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttribL4d;

        /// <summary>void glVertexAttribL4dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL4dv;

        /// <summary>void glVertexAttribLPointer(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLsizei, void*, void> glVertexAttribLPointer;
    }
}
#endif