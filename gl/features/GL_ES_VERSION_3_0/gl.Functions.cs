#if (GL_ES_VERSION_3_0 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBeginQuery(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, query, void> glBeginQuery;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBeginTransformFeedback(GLenum primitiveMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindBufferBase(GLenum target, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, void> glBindBufferBase;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, GLintptr, GLsizeiptr, void> glBindBufferRange;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindSampler(GLuint unit, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, sampler, void> glBindSampler;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindTransformFeedback(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BindTransformFeedbackTarget, transformfeedback, void> glBindTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindVertexArray(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, void> glBindVertexArray;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, BlitFramebufferFilter, void> glBlitFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearBufferfi(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat, GLint, void> glClearBufferfi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearBufferfv(GLenum buffer, GLint drawbuffer, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat*, void> glClearBufferfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearBufferiv(GLenum buffer, GLint drawbuffer, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLint*, void> glClearBufferiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearBufferuiv(GLenum buffer, GLint drawbuffer, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLuint*, void> glClearBufferuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLenum glClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncObjectMask, GLuint64, SyncStatus> glClientWaitSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CopyBufferSubDataTarget, CopyBufferSubDataTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteQueries(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glDeleteQueries;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, sampler*, void> glDeleteSamplers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, void> glDeleteSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glDeleteTransformFeedbacks;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glDeleteVertexArrays;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstanced;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawBuffers(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, DrawBufferMode*, void> glDrawBuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, void> glDrawElementsInstanced;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, void> glDrawRangeElements;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEndQuery(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQuery;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEndTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLsync glFenceSync(GLenum condition, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, sync> glFenceSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRange;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, GLint, void> glFramebufferTextureLayer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenQueries(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, query*, void> glGenQueries;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, sampler*, void> glGenSamplers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glGenTransformFeedbacks;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glGenVertexArrays;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, UniformBlockPName, GLint*, void> glGetActiveUniformBlockiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformBlockName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniformsiv(GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLuint*, UniformPName, GLint*, void> glGetActiveUniformsiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBufferParameteri64v(GLenum target, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint64*, void> glGetBufferParameteri64v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBufferPointerv(GLenum target, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPointerNameARB, void**, void> glGetBufferPointerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetFragDataLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetFragDataLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetInteger64i_v(GLenum target, GLuint index, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint64*, void> glGetInteger64i_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetInteger64v(GLenum pname, GLint64* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetInternalformativ(GLenum target, GLenum internalformat, GLenum pname, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint*, void> glGetInternalformativ;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramBinary(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinary;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryiv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryObjectuiv(GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat*, void> glGetSamplerParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLubyte* glGetStringi(GLenum name, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLuint, GLubyte*> glGetStringi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSynciv(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSynciv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLsizei*, AttributeType*, GLchar*, void> glGetTransformFeedbackVarying;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetUniformBlockIndex(GLuint program, GLchar* uniformBlockName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLuint> glGetUniformBlockIndex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformIndices(GLuint program, GLsizei uniformCount, GLchar** uniformNames, GLuint* uniformIndices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLchar**, GLuint*, void> glGetUniformIndices;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformuiv(GLuint program, GLint location, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint*, void> glGetUniformuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribIiv(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint*, void> glGetVertexAttribIiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribIuiv(GLuint index, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint*, void> glGetVertexAttribIuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glInvalidateFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateSubFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateSubFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsQuery(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, GLboolean> glIsQuery;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsSampler(GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, GLboolean> glIsSampler;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsSync(GLsync sync);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, GLboolean> glIsSync;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsTransformFeedback(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, GLboolean> glIsTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsVertexArray(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLboolean> glIsVertexArray;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void* glMapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapBufferRange;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPauseTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedback;
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
        /// <summary>void glReadBuffer(GLenum src);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReadBufferMode, void> glReadBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisample;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glResumeTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat, void> glSamplerParameterf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat*, void> glSamplerParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameteri(GLuint sampler, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint, void> glSamplerParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameteriv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTexStorage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTransformFeedbackVaryings(GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLchar**, TransformFeedbackBufferMode, void> glTransformFeedbackVaryings;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1ui(GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, void> glUniform1ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform1uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2ui(GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, void> glUniform2ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform2uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3ui(GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, void> glUniform3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4ui(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, GLuint, void> glUniform4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLuint, void> glUniformBlockBinding;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glUnmapBuffer(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLboolean> glUnmapBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribDivisor(GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisor;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, GLint, void> glVertexAttribI4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI4iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI4uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void*, void> glVertexAttribIPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sync, SyncBehaviorFlags, GLuint64, void> glWaitSync;
#endif
    }
}
#endif