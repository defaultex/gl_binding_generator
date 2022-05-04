#if (GL_VERSION_4_1 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glActiveShaderProgram(GLuint pipeline, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, program, void> glActiveShaderProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, void> glBindProgramPipeline;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearDepthf(GLfloat d);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glCreateShaderProgramv(GLenum type, GLsizei count, GLchar** strings);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLchar**, program> glCreateShaderProgramv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, programpipeline*, void> glDeleteProgramPipelines;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthRangeArrayv(GLuint first, GLsizei count, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glDepthRangeArrayv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthRangef(GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthRangeIndexed(GLuint index, GLdouble n, GLdouble f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glDepthRangeIndexed;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, programpipeline*, void> glGenProgramPipelines;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetDoublei_v(GLenum target, GLuint index, GLdouble* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLdouble*, void> glGetDoublei_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetFloati_v(GLenum target, GLuint index, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramBinary(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinary;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramPipelineInfoLog(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, GLsizei, GLsizei*, GLchar*, void> glGetProgramPipelineInfoLog;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramPipelineiv(GLuint pipeline, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, PipelineParameterName, GLint*, void> glGetProgramPipelineiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, PrecisionType, GLint*, GLint*, void> glGetShaderPrecisionFormat;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribLdv(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLdouble*, void> glGetVertexAttribLdv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, GLboolean> glIsProgramPipeline;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramBinary(GLuint program, GLenum binaryFormat, void* binary, GLsizei length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLenum, void*, GLsizei, void> glProgramBinary;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramParameteri(GLuint program, GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramParameterPName, GLint, void> glProgramParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1d(GLuint program, GLint location, GLdouble v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, void> glProgramUniform1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform1dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1f(GLuint program, GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, void> glProgramUniform1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1i(GLuint program, GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, void> glProgramUniform1i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform1iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1ui(GLuint program, GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, void> glProgramUniform1ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform1uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform1uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2d(GLuint program, GLint location, GLdouble v0, GLdouble v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, GLdouble, void> glProgramUniform2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2f(GLuint program, GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, void> glProgramUniform2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2i(GLuint program, GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, void> glProgramUniform2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2ui(GLuint program, GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, void> glProgramUniform2ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform2uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform2uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, GLdouble, GLdouble, void> glProgramUniform3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, GLfloat, void> glProgramUniform3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, GLint, void> glProgramUniform3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, GLuint, void> glProgramUniform3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform3uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramUniform4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4dv(GLuint program, GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLdouble*, void> glProgramUniform4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramUniform4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4fv(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, GLint, GLint, void> glProgramUniform4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4iv(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, GLuint, GLuint, void> glProgramUniform4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniform4uiv(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glReleaseShaderCompiler();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glReleaseShaderCompiler;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glScissorArrayv(GLuint first, GLsizei count, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glScissorIndexed(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexed;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glScissorIndexedv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glShaderBinary(GLsizei count, GLuint* shaders, GLenum binaryFormat, void* binary, GLsizei length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, shader*, ShaderBinaryFormat, void*, GLsizei, void> glShaderBinary;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUseProgramStages(GLuint pipeline, GLbitfield stages, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, UseProgramStageMask, program, void> glUseProgramStages;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glValidateProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, void> glValidateProgramPipeline;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL1d(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttribL1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL1dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL1dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL2d(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttribL2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL2dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttribL3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL3dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttribL4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribL4dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribLPointer(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLsizei, void*, void> glVertexAttribLPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glViewportArrayv(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glViewportIndexedf(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glViewportIndexedfv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfv;
#endif
    }
}
#endif