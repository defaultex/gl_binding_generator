#if (GL_ARB_shader_subroutine && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetActiveSubroutineName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineName;

        /// <summary>void glGetActiveSubroutineUniformName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineUniformName;

        /// <summary>void glGetActiveSubroutineUniformiv(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, SubroutineParameterName, GLint*, void> glGetActiveSubroutineUniformiv;

        /// <summary>void glGetProgramStageiv(GLuint program, GLenum shadertype, GLenum pname, GLint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, ProgramStagePName, GLint*, void> glGetProgramStageiv;

        /// <summary>GLuint glGetSubroutineIndex(GLuint program, GLenum shadertype, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLchar*, GLuint> glGetSubroutineIndex;

        /// <summary>GLint glGetSubroutineUniformLocation(GLuint program, GLenum shadertype, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLchar*, GLint> glGetSubroutineUniformLocation;

        /// <summary>void glGetUniformSubroutineuiv(GLenum shadertype, GLint location, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLint, GLuint*, void> glGetUniformSubroutineuiv;

        /// <summary>void glUniformSubroutinesuiv(GLenum shadertype, GLsizei count, const GLuint* indices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLuint*, void> glUniformSubroutinesuiv;
    }
}
#endif