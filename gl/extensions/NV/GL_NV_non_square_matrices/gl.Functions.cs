#if (GL_NV_non_square_matrices && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glUniformMatrix2x3fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x3fvNV;

        /// <summary>void glUniformMatrix2x4fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x4fvNV;

        /// <summary>void glUniformMatrix3x2fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x2fvNV;

        /// <summary>void glUniformMatrix3x4fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x4fvNV;

        /// <summary>void glUniformMatrix4x2fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x2fvNV;

        /// <summary>void glUniformMatrix4x3fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x3fvNV;
    }
}
#endif