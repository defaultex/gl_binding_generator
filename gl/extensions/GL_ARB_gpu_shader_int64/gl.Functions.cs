#if GL_ARB_gpu_shader_int64

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64*, void> glGetnUniformi64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glGetnUniformui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64*, void> glGetUniformi64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64*, void> glGetUniformui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64, void> glProgramUniform1i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64*, void> glProgramUniform1i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, void> glProgramUniform1ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniform1ui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64, GLint64, void> glProgramUniform2i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64*, void> glProgramUniform2i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, GLuint64, void> glProgramUniform2ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniform2ui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64, GLint64, GLint64, void> glProgramUniform3i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64*, void> glProgramUniform3i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, GLuint64, GLuint64, void> glProgramUniform3ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniform3ui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint64, GLint64, GLint64, GLint64, void> glProgramUniform4i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint64*, void> glProgramUniform4i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, GLuint64, GLuint64, GLuint64, void> glProgramUniform4ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniform4ui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, void> glUniform1i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform1i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniform1ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform1ui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, GLint64, void> glUniform2i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform2i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, GLuint64, void> glUniform2ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform2ui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, GLint64, GLint64, void> glUniform3i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform3i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, GLuint64, GLuint64, void> glUniform3ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform3ui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint64, GLint64, GLint64, GLint64, void> glUniform4i64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint64*, void> glUniform4i64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, GLuint64, GLuint64, GLuint64, void> glUniform4ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniform4ui64vARB;
    }
}

#endif