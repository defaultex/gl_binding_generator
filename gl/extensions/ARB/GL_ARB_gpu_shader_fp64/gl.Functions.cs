#if (GL_ARB_gpu_shader_fp64 && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetUniformdv(GLuint program, GLint location, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble*, void> glGetUniformdv;

        /// <summary>void glUniform1d(GLint location, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, void> glUniform1d;

        /// <summary>void glUniform1dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform1dv;

        /// <summary>void glUniform2d(GLint location, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, void> glUniform2d;

        /// <summary>void glUniform2dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform2dv;

        /// <summary>void glUniform3d(GLint location, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, void> glUniform3d;

        /// <summary>void glUniform3dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform3dv;

        /// <summary>void glUniform4d(GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glUniform4d;

        /// <summary>void glUniform4dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform4dv;

        /// <summary>void glUniformMatrix2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2dv;

        /// <summary>void glUniformMatrix2x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x3dv;

        /// <summary>void glUniformMatrix2x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x4dv;

        /// <summary>void glUniformMatrix3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3dv;

        /// <summary>void glUniformMatrix3x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x2dv;

        /// <summary>void glUniformMatrix3x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x4dv;

        /// <summary>void glUniformMatrix4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4dv;

        /// <summary>void glUniformMatrix4x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x2dv;

        /// <summary>void glUniformMatrix4x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x3dv;
    }
}
#endif