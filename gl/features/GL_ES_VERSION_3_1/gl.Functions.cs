#if (GL_ES_VERSION_3_1 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glActiveShaderProgram(GLuint pipeline, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLprogram, void> glActiveShaderProgram;

        /// <summary>void glBindImageTexture(GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLtexture, GLint, GLboolean, GLint, BufferAccessARB, InternalFormat, void> glBindImageTexture;

        /// <summary>void glBindProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glBindProgramPipeline;

        /// <summary>void glBindVertexBuffer(GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbuffer, GLintptr, GLsizei, void> glBindVertexBuffer;

        /// <summary>GLuint glCreateShaderProgramv(GLenum type, GLsizei count, GLchar** strings);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLchar**, GLprogram> glCreateShaderProgramv;

        /// <summary>void glDeleteProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glDeleteProgramPipelines;

        /// <summary>void glDispatchCompute(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glDispatchCompute;

        /// <summary>void glDispatchComputeIndirect(GLintptr indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDispatchComputeIndirect;

        /// <summary>void glDrawArraysIndirect(GLenum mode, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, void> glDrawArraysIndirect;

        /// <summary>void glDrawElementsIndirect(GLenum mode, GLenum type, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, void> glDrawElementsIndirect;

        /// <summary>void glFramebufferParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, GLint, void> glFramebufferParameteri;

        /// <summary>void glGenProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glGenProgramPipelines;

        /// <summary>void glGetBooleani_v(GLenum target, GLuint index, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleani_v;

        /// <summary>void glGetFramebufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferParameteriv;

        /// <summary>void glGetMultisamplefv(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetMultisamplePNameNV, GLuint, GLfloat*, void> glGetMultisamplefv;

        /// <summary>void glGetProgramInterfaceiv(GLuint program, GLenum programInterface, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, ProgramInterfacePName, GLint*, void> glGetProgramInterfaceiv;

        /// <summary>void glGetProgramPipelineInfoLog(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLsizei, GLsizei*, GLchar*, void> glGetProgramPipelineInfoLog;

        /// <summary>void glGetProgramPipelineiv(GLuint pipeline, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, PipelineParameterName, GLint*, void> glGetProgramPipelineiv;

        /// <summary>GLuint glGetProgramResourceIndex(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLuint> glGetProgramResourceIndex;

        /// <summary>void glGetProgramResourceiv(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei count, GLsizei* length, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, ProgramResourceProperty*, GLsizei, GLsizei*, GLint*, void> glGetProgramResourceiv;

        /// <summary>GLint glGetProgramResourceLocation(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocation;

        /// <summary>void glGetProgramResourceName(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetProgramResourceName;

        /// <summary>void glGetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetTexLevelParameterfv;

        /// <summary>void glGetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetTexLevelParameteriv;

        /// <summary>GLboolean glIsProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, GLboolean> glIsProgramPipeline;

        /// <summary>void glMemoryBarrier(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrier;

        /// <summary>void glMemoryBarrierByRegion(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrierByRegion;

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

        /// <summary>void glProgramUniformMatrix2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fv;

        /// <summary>void glProgramUniformMatrix2x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fv;

        /// <summary>void glProgramUniformMatrix2x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fv;

        /// <summary>void glProgramUniformMatrix3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fv;

        /// <summary>void glProgramUniformMatrix3x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fv;

        /// <summary>void glProgramUniformMatrix3x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fv;

        /// <summary>void glProgramUniformMatrix4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fv;

        /// <summary>void glProgramUniformMatrix4x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fv;

        /// <summary>void glProgramUniformMatrix4x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fv;

        /// <summary>void glSampleMaski(GLuint maskNumber, GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glSampleMaski;

        /// <summary>void glTexStorage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTexStorage2DMultisample;

        /// <summary>void glUseProgramStages(GLuint pipeline, GLbitfield stages, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, UseProgramStageMask, GLprogram, void> glUseProgramStages;

        /// <summary>void glValidateProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogrampipeline, void> glValidateProgramPipeline;

        /// <summary>void glVertexAttribBinding(GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribBinding;

        /// <summary>void glVertexAttribFormat(GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribFormat;

        /// <summary>void glVertexAttribIFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLuint, void> glVertexAttribIFormat;

        /// <summary>void glVertexBindingDivisor(GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexBindingDivisor;
    }
}
#endif