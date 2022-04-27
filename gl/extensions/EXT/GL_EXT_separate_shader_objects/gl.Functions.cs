#if (GL_EXT_separate_shader_objects && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glActiveProgramEXT(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glActiveProgramEXT;

        /// <summary>void glActiveShaderProgramEXT(GLuint pipeline, GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLprogram, void> glActiveShaderProgramEXT;

        /// <summary>void glBindProgramPipelineEXT(GLuint pipeline)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glBindProgramPipelineEXT;

        /// <summary>GLuint glCreateShaderProgramEXT(GLenum type, const GLchar* string)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLchar*, GLuint> glCreateShaderProgramEXT;

        /// <summary>GLuint glCreateShaderProgramvEXT(GLenum type, GLsizei count, const GLchar** strings)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLchar**, GLuint> glCreateShaderProgramvEXT;

        /// <summary>void glDeleteProgramPipelinesEXT(GLsizei n, const GLuint* pipelines)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glDeleteProgramPipelinesEXT;

        /// <summary>void glGenProgramPipelinesEXT(GLsizei n, GLuint* pipelines)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glGenProgramPipelinesEXT;

        /// <summary>void glGetProgramPipelineInfoLogEXT(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLsizei, GLsizei*, GLchar*, void> glGetProgramPipelineInfoLogEXT;

        /// <summary>void glGetProgramPipelineivEXT(GLuint pipeline, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, PipelineParameterName, GLint*, void> glGetProgramPipelineivEXT;

        /// <summary>GLboolean glIsProgramPipelineEXT(GLuint pipeline)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLboolean> glIsProgramPipelineEXT;

        /// <summary>void glProgramParameteriEXT(GLuint program, GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramParameterPName, GLint, void> glProgramParameteriEXT;

        /// <summary>void glProgramUniform1fEXT(GLuint program, GLint location, GLfloat v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, void> glProgramUniform1fEXT;

        /// <summary>void glProgramUniform1fvEXT(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform1fvEXT;

        /// <summary>void glProgramUniform1iEXT(GLuint program, GLint location, GLint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, void> glProgramUniform1iEXT;

        /// <summary>void glProgramUniform1ivEXT(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform1ivEXT;

        /// <summary>void glProgramUniform1uiEXT(GLuint program, GLint location, GLuint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, void> glProgramUniform1uiEXT;

        /// <summary>void glProgramUniform1uivEXT(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform1uivEXT;

        /// <summary>void glProgramUniform2fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, void> glProgramUniform2fEXT;

        /// <summary>void glProgramUniform2fvEXT(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform2fvEXT;

        /// <summary>void glProgramUniform2iEXT(GLuint program, GLint location, GLint v0, GLint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, void> glProgramUniform2iEXT;

        /// <summary>void glProgramUniform2ivEXT(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform2ivEXT;

        /// <summary>void glProgramUniform2uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, void> glProgramUniform2uiEXT;

        /// <summary>void glProgramUniform2uivEXT(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform2uivEXT;

        /// <summary>void glProgramUniform3fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, void> glProgramUniform3fEXT;

        /// <summary>void glProgramUniform3fvEXT(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform3fvEXT;

        /// <summary>void glProgramUniform3iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, void> glProgramUniform3iEXT;

        /// <summary>void glProgramUniform3ivEXT(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform3ivEXT;

        /// <summary>void glProgramUniform3uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, void> glProgramUniform3uiEXT;

        /// <summary>void glProgramUniform3uivEXT(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform3uivEXT;

        /// <summary>void glProgramUniform4fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramUniform4fEXT;

        /// <summary>void glProgramUniform4fvEXT(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform4fvEXT;

        /// <summary>void glProgramUniform4iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, GLint, void> glProgramUniform4iEXT;

        /// <summary>void glProgramUniform4ivEXT(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform4ivEXT;

        /// <summary>void glProgramUniform4uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, GLuint, void> glProgramUniform4uiEXT;

        /// <summary>void glProgramUniform4uivEXT(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform4uivEXT;

        /// <summary>void glProgramUniformMatrix2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fvEXT;

        /// <summary>void glProgramUniformMatrix2x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fvEXT;

        /// <summary>void glProgramUniformMatrix2x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fvEXT;

        /// <summary>void glProgramUniformMatrix3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fvEXT;

        /// <summary>void glProgramUniformMatrix3x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fvEXT;

        /// <summary>void glProgramUniformMatrix3x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fvEXT;

        /// <summary>void glProgramUniformMatrix4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fvEXT;

        /// <summary>void glProgramUniformMatrix4x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fvEXT;

        /// <summary>void glProgramUniformMatrix4x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fvEXT;

        /// <summary>void glUseProgramStagesEXT(GLuint pipeline, GLbitfield stages, GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, UseProgramStageMask, GLprogram, void> glUseProgramStagesEXT;

        /// <summary>void glUseShaderProgramEXT(GLenum type, GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLprogram, void> glUseShaderProgramEXT;

        /// <summary>void glValidateProgramPipelineEXT(GLuint pipeline)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glValidateProgramPipelineEXT;
    }
}
#endif