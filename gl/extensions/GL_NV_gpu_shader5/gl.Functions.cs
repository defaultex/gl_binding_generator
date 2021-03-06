#if GL_NV_gpu_shader5

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glGetUniformi64vNV(GLuint program, GLint location, GLint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT*, void> glGetUniformi64vNV;

        /// <summary>void glProgramUniform1i64NV(GLuint program, GLint location, GLint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, void> glProgramUniform1i64NV;

        /// <summary>void glProgramUniform1i64vNV(GLuint program, GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform1i64vNV;

        /// <summary>void glProgramUniform1ui64NV(GLuint program, GLint location, GLuint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, void> glProgramUniform1ui64NV;

        /// <summary>void glProgramUniform1ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform1ui64vNV;

        /// <summary>void glProgramUniform2i64NV(GLuint program, GLint location, GLint64EXT x, GLint64EXT y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, GLint64EXT, void> glProgramUniform2i64NV;

        /// <summary>void glProgramUniform2i64vNV(GLuint program, GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform2i64vNV;

        /// <summary>void glProgramUniform2ui64NV(GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, GLuint64EXT, void> glProgramUniform2ui64NV;

        /// <summary>void glProgramUniform2ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform2ui64vNV;

        /// <summary>void glProgramUniform3i64NV(GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, GLint64EXT, GLint64EXT, void> glProgramUniform3i64NV;

        /// <summary>void glProgramUniform3i64vNV(GLuint program, GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform3i64vNV;

        /// <summary>void glProgramUniform3ui64NV(GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glProgramUniform3ui64NV;

        /// <summary>void glProgramUniform3ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform3ui64vNV;

        /// <summary>void glProgramUniform4i64NV(GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, GLint64EXT, GLint64EXT, GLint64EXT, void> glProgramUniform4i64NV;

        /// <summary>void glProgramUniform4i64vNV(GLuint program, GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform4i64vNV;

        /// <summary>void glProgramUniform4ui64NV(GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glProgramUniform4ui64NV;

        /// <summary>void glProgramUniform4ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform4ui64vNV;

        /// <summary>void glUniform1i64NV(GLint location, GLint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, void> glUniform1i64NV;

        /// <summary>void glUniform1i64vNV(GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform1i64vNV;

        /// <summary>void glUniform1ui64NV(GLint location, GLuint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, void> glUniform1ui64NV;

        /// <summary>void glUniform1ui64vNV(GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform1ui64vNV;

        /// <summary>void glUniform2i64NV(GLint location, GLint64EXT x, GLint64EXT y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, GLint64EXT, void> glUniform2i64NV;

        /// <summary>void glUniform2i64vNV(GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform2i64vNV;

        /// <summary>void glUniform2ui64NV(GLint location, GLuint64EXT x, GLuint64EXT y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, GLuint64EXT, void> glUniform2ui64NV;

        /// <summary>void glUniform2ui64vNV(GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform2ui64vNV;

        /// <summary>void glUniform3i64NV(GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, GLint64EXT, GLint64EXT, void> glUniform3i64NV;

        /// <summary>void glUniform3i64vNV(GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform3i64vNV;

        /// <summary>void glUniform3ui64NV(GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glUniform3ui64NV;

        /// <summary>void glUniform3ui64vNV(GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform3ui64vNV;

        /// <summary>void glUniform4i64NV(GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, GLint64EXT, GLint64EXT, GLint64EXT, void> glUniform4i64NV;

        /// <summary>void glUniform4i64vNV(GLint location, GLsizei count, GLint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform4i64vNV;

        /// <summary>void glUniform4ui64NV(GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glUniform4ui64NV;

        /// <summary>void glUniform4ui64vNV(GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform4ui64vNV;
    }
}

#endif