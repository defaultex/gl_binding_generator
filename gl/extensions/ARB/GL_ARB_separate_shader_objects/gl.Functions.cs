#if (GL_ARB_separate_shader_objects && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glActiveShaderProgram(GLuint pipeline, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLprogram, void> glActiveShaderProgram;

        /// <summary>void glBindProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glBindProgramPipeline;

        /// <summary>GLuint glCreateShaderProgramv(GLenum type, GLsizei count, GLchar** strings);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLchar**, GLprogram> glCreateShaderProgramv;

        /// <summary>void glDeleteProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glDeleteProgramPipelines;

        /// <summary>void glGenProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glGenProgramPipelines;

        /// <summary>void glGetProgramPipelineInfoLog(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLsizei, GLsizei*, GLchar*, void> glGetProgramPipelineInfoLog;

        /// <summary>void glGetProgramPipelineiv(GLuint pipeline, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, PipelineParameterName, GLint*, void> glGetProgramPipelineiv;

        /// <summary>GLboolean glIsProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLboolean> glIsProgramPipeline;

        /// <summary>void glProgramUniform1d(GLuint program, GLint location, GLdouble v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, void> glProgramUniform1d;

        /// <summary>void glProgramUniform1dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform1dv;

        /// <summary>void glProgramUniform1f(GLuint program, GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, void> glProgramUniform1f;

        /// <summary>void glProgramUniform1fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform1fv;

        /// <summary>void glProgramUniform1i(GLuint program, GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, void> glProgramUniform1i;

        /// <summary>void glProgramUniform1iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform1iv;

        /// <summary>void glProgramUniform1ui(GLuint program, GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, void> glProgramUniform1ui;

        /// <summary>void glProgramUniform1uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform1uiv;

        /// <summary>void glProgramUniform2d(GLuint program, GLint location, GLdouble v0, GLdouble v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, void> glProgramUniform2d;

        /// <summary>void glProgramUniform2dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform2dv;

        /// <summary>void glProgramUniform2f(GLuint program, GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, void> glProgramUniform2f;

        /// <summary>void glProgramUniform2fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform2fv;

        /// <summary>void glProgramUniform2i(GLuint program, GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, void> glProgramUniform2i;

        /// <summary>void glProgramUniform2iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform2iv;

        /// <summary>void glProgramUniform2ui(GLuint program, GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, void> glProgramUniform2ui;

        /// <summary>void glProgramUniform2uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform2uiv;

        /// <summary>void glProgramUniform3d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, GLdouble, void> glProgramUniform3d;

        /// <summary>void glProgramUniform3dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform3dv;

        /// <summary>void glProgramUniform3f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, void> glProgramUniform3f;

        /// <summary>void glProgramUniform3fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform3fv;

        /// <summary>void glProgramUniform3i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, void> glProgramUniform3i;

        /// <summary>void glProgramUniform3iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform3iv;

        /// <summary>void glProgramUniform3ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, void> glProgramUniform3ui;

        /// <summary>void glProgramUniform3uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform3uiv;

        /// <summary>void glProgramUniform4d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramUniform4d;

        /// <summary>void glProgramUniform4dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform4dv;

        /// <summary>void glProgramUniform4f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramUniform4f;

        /// <summary>void glProgramUniform4fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform4fv;

        /// <summary>void glProgramUniform4i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, GLint, void> glProgramUniform4i;

        /// <summary>void glProgramUniform4iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform4iv;

        /// <summary>void glProgramUniform4ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, GLuint, void> glProgramUniform4ui;

        /// <summary>void glProgramUniform4uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform4uiv;

        /// <summary>void glProgramUniformMatrix2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2dv;

        /// <summary>void glProgramUniformMatrix2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fv;

        /// <summary>void glProgramUniformMatrix2x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x3dv;

        /// <summary>void glProgramUniformMatrix2x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fv;

        /// <summary>void glProgramUniformMatrix2x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x4dv;

        /// <summary>void glProgramUniformMatrix2x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fv;

        /// <summary>void glProgramUniformMatrix3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3dv;

        /// <summary>void glProgramUniformMatrix3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fv;

        /// <summary>void glProgramUniformMatrix3x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x2dv;

        /// <summary>void glProgramUniformMatrix3x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fv;

        /// <summary>void glProgramUniformMatrix3x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x4dv;

        /// <summary>void glProgramUniformMatrix3x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fv;

        /// <summary>void glProgramUniformMatrix4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4dv;

        /// <summary>void glProgramUniformMatrix4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fv;

        /// <summary>void glProgramUniformMatrix4x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x2dv;

        /// <summary>void glProgramUniformMatrix4x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fv;

        /// <summary>void glProgramUniformMatrix4x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x3dv;

        /// <summary>void glProgramUniformMatrix4x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fv;

        /// <summary>void glUseProgramStages(GLuint pipeline, GLbitfield stages, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, UseProgramStageMask, GLprogram, void> glUseProgramStages;

        /// <summary>void glValidateProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glValidateProgramPipeline;
    }
}
#endif