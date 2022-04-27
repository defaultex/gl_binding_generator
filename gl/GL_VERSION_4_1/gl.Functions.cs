#if (GL_VERSION_4_1 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if !GL_ES_VERSION_3_1

        /// <summary>void glActiveShaderProgram(GLuint pipeline, GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLprogram, void> glActiveShaderProgram;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glBindProgramPipeline(GLuint pipeline)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glBindProgramPipeline;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glClearDepthf(GLfloat d)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>GLuint glCreateShaderProgramv(GLenum type, GLsizei count, const GLchar*const* strings)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLchar**, GLuint> glCreateShaderProgramv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glDeleteProgramPipelines(GLsizei n, const GLuint* pipelines)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glDeleteProgramPipelines;

#endif

        /// <summary>void glDepthRangeArrayv(GLuint first, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glDepthRangeArrayv;

        /// <summary>void glDepthRangeIndexed(GLuint index, GLdouble n, GLdouble f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glDepthRangeIndexed;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glDepthRangef(GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glGenProgramPipelines(GLsizei n, GLuint* pipelines)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glGenProgramPipelines;

#endif

        /// <summary>void glGetDoublei_v(GLenum target, GLuint index, GLdouble* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLdouble*, void> glGetDoublei_v;

        /// <summary>void glGetFloati_v(GLenum target, GLuint index, GLfloat* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_v;

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetProgramBinary(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinary;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glGetProgramPipelineInfoLog(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLsizei, GLsizei*, GLchar*, void> glGetProgramPipelineInfoLog;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glGetProgramPipelineiv(GLuint pipeline, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, PipelineParameterName, GLint*, void> glGetProgramPipelineiv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, PrecisionType, GLint*, GLint*, void> glGetShaderPrecisionFormat;

#endif

        /// <summary>void glGetVertexAttribLdv(GLuint index, GLenum pname, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLdouble*, void> glGetVertexAttribLdv;

#if !GL_ES_VERSION_3_1

        /// <summary>GLboolean glIsProgramPipeline(GLuint pipeline)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLboolean> glIsProgramPipeline;

#endif

#if (!GL_ES_VERSION_3_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glProgramBinary(GLuint program, GLenum binaryFormat, const void* binary, GLsizei length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLenum, void*, GLsizei, void> glProgramBinary;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glProgramParameteri(GLuint program, GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramParameterPName, GLint, void> glProgramParameteri;

#endif

        /// <summary>void glProgramUniform1d(GLuint program, GLint location, GLdouble v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, void> glProgramUniform1d;

        /// <summary>void glProgramUniform1dv(GLuint program, GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform1dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform1f(GLuint program, GLint location, GLfloat v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, void> glProgramUniform1f;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform1fv(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform1fv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform1i(GLuint program, GLint location, GLint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, void> glProgramUniform1i;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform1iv(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform1iv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform1ui(GLuint program, GLint location, GLuint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, void> glProgramUniform1ui;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform1uiv(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform1uiv;

#endif

        /// <summary>void glProgramUniform2d(GLuint program, GLint location, GLdouble v0, GLdouble v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, void> glProgramUniform2d;

        /// <summary>void glProgramUniform2dv(GLuint program, GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform2dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform2f(GLuint program, GLint location, GLfloat v0, GLfloat v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, void> glProgramUniform2f;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform2fv(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform2fv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform2i(GLuint program, GLint location, GLint v0, GLint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, void> glProgramUniform2i;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform2iv(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform2iv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform2ui(GLuint program, GLint location, GLuint v0, GLuint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, void> glProgramUniform2ui;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform2uiv(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform2uiv;

#endif

        /// <summary>void glProgramUniform3d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, GLdouble, void> glProgramUniform3d;

        /// <summary>void glProgramUniform3dv(GLuint program, GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform3dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform3f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, void> glProgramUniform3f;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform3fv(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform3fv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform3i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, void> glProgramUniform3i;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform3iv(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform3iv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform3ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, void> glProgramUniform3ui;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform3uiv(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform3uiv;

#endif

        /// <summary>void glProgramUniform4d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramUniform4d;

        /// <summary>void glProgramUniform4dv(GLuint program, GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glProgramUniform4dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform4f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramUniform4f;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform4fv(GLuint program, GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glProgramUniform4fv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform4i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint, GLint, GLint, GLint, void> glProgramUniform4i;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform4iv(GLuint program, GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glProgramUniform4iv;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform4ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint, GLuint, GLuint, GLuint, void> glProgramUniform4ui;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniform4uiv(GLuint program, GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glProgramUniform4uiv;

#endif

        /// <summary>void glProgramUniformMatrix2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fv;

#endif

        /// <summary>void glProgramUniformMatrix2x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x3dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix2x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fv;

#endif

        /// <summary>void glProgramUniformMatrix2x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix2x4dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix2x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fv;

#endif

        /// <summary>void glProgramUniformMatrix3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fv;

#endif

        /// <summary>void glProgramUniformMatrix3x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x2dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix3x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fv;

#endif

        /// <summary>void glProgramUniformMatrix3x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix3x4dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix3x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fv;

#endif

        /// <summary>void glProgramUniformMatrix4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fv;

#endif

        /// <summary>void glProgramUniformMatrix4x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x2dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix4x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fv;

#endif

        /// <summary>void glProgramUniformMatrix4x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLdouble*, void> glProgramUniformMatrix4x3dv;

#if !GL_ES_VERSION_3_1

        /// <summary>void glProgramUniformMatrix4x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glReleaseShaderCompiler()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glReleaseShaderCompiler;

#endif

        /// <summary>void glScissorArrayv(GLuint first, GLsizei count, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayv;

        /// <summary>void glScissorIndexed(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexed;

        /// <summary>void glScissorIndexedv(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedv;

#if !GL_ES_VERSION_2_0

        /// <summary>void glShaderBinary(GLsizei count, const GLuint* shaders, GLenum binaryFormat, const void* binary, GLsizei length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLshader*, ShaderBinaryFormat, void*, GLsizei, void> glShaderBinary;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glUseProgramStages(GLuint pipeline, GLbitfield stages, GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, UseProgramStageMask, GLprogram, void> glUseProgramStages;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glValidateProgramPipeline(GLuint pipeline)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glValidateProgramPipeline;

#endif

        /// <summary>void glVertexAttribL1d(GLuint index, GLdouble x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttribL1d;

        /// <summary>void glVertexAttribL1dv(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL1dv;

        /// <summary>void glVertexAttribL2d(GLuint index, GLdouble x, GLdouble y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttribL2d;

        /// <summary>void glVertexAttribL2dv(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL2dv;

        /// <summary>void glVertexAttribL3d(GLuint index, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttribL3d;

        /// <summary>void glVertexAttribL3dv(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL3dv;

        /// <summary>void glVertexAttribL4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttribL4d;

        /// <summary>void glVertexAttribL4dv(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL4dv;

        /// <summary>void glVertexAttribLPointer(GLuint index, GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLsizei, void*, void> glVertexAttribLPointer;

        /// <summary>void glViewportArrayv(GLuint first, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayv;

        /// <summary>void glViewportIndexedf(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedf;

        /// <summary>void glViewportIndexedfv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfv;
    }
}
#endif