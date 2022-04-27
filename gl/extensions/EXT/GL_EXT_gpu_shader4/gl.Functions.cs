#if (GL_EXT_gpu_shader4 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindFragDataLocationEXT(GLuint program, GLuint color, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLchar*, void> glBindFragDataLocationEXT;

        /// <summary>GLint glGetFragDataLocationEXT(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataLocationEXT;

        /// <summary>void glGetUniformuivEXT(GLuint program, GLint location, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint*, void> glGetUniformuivEXT;

        /// <summary>void glGetVertexAttribIivEXT(GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint*, void> glGetVertexAttribIivEXT;

        /// <summary>void glGetVertexAttribIuivEXT(GLuint index, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint*, void> glGetVertexAttribIuivEXT;

        /// <summary>void glUniform1uiEXT(GLint location, GLuint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, void> glUniform1uiEXT;

        /// <summary>void glUniform1uivEXT(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform1uivEXT;

        /// <summary>void glUniform2uiEXT(GLint location, GLuint v0, GLuint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, void> glUniform2uiEXT;

        /// <summary>void glUniform2uivEXT(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform2uivEXT;

        /// <summary>void glUniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, void> glUniform3uiEXT;

        /// <summary>void glUniform3uivEXT(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform3uivEXT;

        /// <summary>void glUniform4uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, GLuint, void> glUniform4uiEXT;

        /// <summary>void glUniform4uivEXT(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform4uivEXT;

        /// <summary>void glVertexAttribI1iEXT(GLuint index, GLint x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, void> glVertexAttribI1iEXT;

        /// <summary>void glVertexAttribI1ivEXT(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI1ivEXT;

        /// <summary>void glVertexAttribI1uiEXT(GLuint index, GLuint x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribI1uiEXT;

        /// <summary>void glVertexAttribI1uivEXT(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI1uivEXT;

        /// <summary>void glVertexAttribI2iEXT(GLuint index, GLint x, GLint y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, void> glVertexAttribI2iEXT;

        /// <summary>void glVertexAttribI2ivEXT(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI2ivEXT;

        /// <summary>void glVertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glVertexAttribI2uiEXT;

        /// <summary>void glVertexAttribI2uivEXT(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI2uivEXT;

        /// <summary>void glVertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, void> glVertexAttribI3iEXT;

        /// <summary>void glVertexAttribI3ivEXT(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI3ivEXT;

        /// <summary>void glVertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI3uiEXT;

        /// <summary>void glVertexAttribI3uivEXT(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI3uivEXT;

        /// <summary>void glVertexAttribI4bvEXT(GLuint index, const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttribI4bvEXT;

        /// <summary>void glVertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, GLint, void> glVertexAttribI4iEXT;

        /// <summary>void glVertexAttribI4ivEXT(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI4ivEXT;

        /// <summary>void glVertexAttribI4svEXT(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttribI4svEXT;

        /// <summary>void glVertexAttribI4ubvEXT(GLuint index, const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttribI4ubvEXT;

        /// <summary>void glVertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI4uiEXT;

        /// <summary>void glVertexAttribI4uivEXT(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI4uivEXT;

        /// <summary>void glVertexAttribI4usvEXT(GLuint index, const GLushort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttribI4usvEXT;

        /// <summary>void glVertexAttribIPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void*, void> glVertexAttribIPointerEXT;
    }
}
#endif