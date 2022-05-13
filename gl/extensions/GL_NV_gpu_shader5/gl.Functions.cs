#if GL_NV_gpu_shader5

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT*, void> glGetUniformi64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, void> glProgramUniform1i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform1i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, void> glProgramUniform1ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform1ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, GLint64EXT, void> glProgramUniform2i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform2i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, GLuint64EXT, void> glProgramUniform2ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform2ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, GLint64EXT, GLint64EXT, void> glProgramUniform3i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform3i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glProgramUniform3ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform3ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64EXT, GLint64EXT, GLint64EXT, GLint64EXT, void> glProgramUniform4i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64EXT*, void> glProgramUniform4i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glProgramUniform4ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniform4ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, void> glUniform1i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform1i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, void> glUniform1ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform1ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, GLint64EXT, void> glUniform2i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform2i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, GLuint64EXT, void> glUniform2ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform2ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, GLint64EXT, GLint64EXT, void> glUniform3i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform3i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glUniform3ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform3ui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64EXT, GLint64EXT, GLint64EXT, GLint64EXT, void> glUniform4i64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64EXT*, void> glUniform4i64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, GLuint64EXT, GLuint64EXT, GLuint64EXT, void> glUniform4ui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniform4ui64vNV;
    }
}

#endif