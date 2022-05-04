#if (GL_ES_VERSION_3_1 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glActiveShaderProgram(GLuint pipeline, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, program, void> glActiveShaderProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindImageTexture(GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, texture, GLint, GLboolean, GLint, BufferAccessARB, InternalFormat, void> glBindImageTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, void> glBindProgramPipeline;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindVertexBuffer(GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, buffer, GLintptr, GLsizei, void> glBindVertexBuffer;
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
        /// <summary>void glDispatchCompute(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glDispatchCompute;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDispatchComputeIndirect(GLintptr indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDispatchComputeIndirect;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawArraysIndirect(GLenum mode, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, void> glDrawArraysIndirect;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsIndirect(GLenum mode, GLenum type, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, void> glDrawElementsIndirect;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, GLint, void> glFramebufferParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, programpipeline*, void> glGenProgramPipelines;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBooleani_v(GLenum target, GLuint index, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleani_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetFramebufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetMultisamplefv(GLenum pname, GLuint index, GLfloat* val);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetMultisamplePNameNV, GLuint, GLfloat*, void> glGetMultisamplefv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramInterfaceiv(GLuint program, GLenum programInterface, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, ProgramInterfacePName, GLint*, void> glGetProgramInterfaceiv;
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
        /// <summary>GLuint glGetProgramResourceIndex(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLchar*, GLuint> glGetProgramResourceIndex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramResourceiv(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei count, GLsizei* length, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLuint, GLsizei, ProgramResourceProperty*, GLsizei, GLsizei*, GLint*, void> glGetProgramResourceiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetProgramResourceLocation(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramResourceName(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetProgramResourceName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLfloat*, void> glGetTexLevelParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLint*, void> glGetTexLevelParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsProgramPipeline(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, GLboolean> glIsProgramPipeline;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMemoryBarrier(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrier;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMemoryBarrierByRegion(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrierByRegion;
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
        /// <summary>void glProgramUniformMatrix2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix2x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix3x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glProgramUniformMatrix4x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSampleMaski(GLuint maskNumber, GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glSampleMaski;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTexStorage2DMultisample;
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
        /// <summary>void glVertexAttribBinding(GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribBinding;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribFormat(GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribFormat;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribIFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLuint, void> glVertexAttribIFormat;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexBindingDivisor(GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexBindingDivisor;
#endif
    }
}
#endif