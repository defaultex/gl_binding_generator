#if (GL_VERSION_2_1 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x3fv;
#endif
    }
}
#endif