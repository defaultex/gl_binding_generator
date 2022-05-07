#if (GL_ATI_vertex_attrib_array_object && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetVertexAttribArrayObjectfvATI(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLfloat*, void> glGetVertexAttribArrayObjectfvATI;

        /// <summary>void glGetVertexAttribArrayObjectivATI(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLint*, void> glGetVertexAttribArrayObjectivATI;

        /// <summary>void glVertexAttribArrayObjectATI(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, GLbuffer, GLuint, void> glVertexAttribArrayObjectATI;
    }
}
#endif