#if (GL_ES_VERSION_3_0 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBeginQuery(GLenum target, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLquery, void> glBeginQuery;

        /// <summary>void glBeginTransformFeedback(GLenum primitiveMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedback;

        /// <summary>void glBindBufferBase(GLenum target, GLuint index, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, void> glBindBufferBase;

        /// <summary>void glBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glBindBufferRange;

        /// <summary>void glBindSampler(GLuint unit, GLuint sampler)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsampler, void> glBindSampler;

        /// <summary>void glBindTransformFeedback(GLenum target, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BindTransformFeedbackTarget, GLtransformfeedback, void> glBindTransformFeedback;

        /// <summary>void glBindVertexArray(GLuint array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, void> glBindVertexArray;

        /// <summary>void glBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, BlitFramebufferFilter, void> glBlitFramebuffer;

        /// <summary>void glClearBufferfi(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat, GLint, void> glClearBufferfi;

        /// <summary>void glClearBufferfv(GLenum buffer, GLint drawbuffer, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat*, void> glClearBufferfv;

        /// <summary>void glClearBufferiv(GLenum buffer, GLint drawbuffer, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLint*, void> glClearBufferiv;

        /// <summary>void glClearBufferuiv(GLenum buffer, GLint drawbuffer, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLuint*, void> glClearBufferuiv;

        /// <summary>GLenum glClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncObjectMask, GLuint64, GLenum> glClientWaitSync;

        /// <summary>void glCompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage3D;

        /// <summary>void glCompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage3D;

        /// <summary>void glCopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CopyBufferSubDataTarget, CopyBufferSubDataTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubData;

        /// <summary>void glCopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage3D;

        /// <summary>void glDeleteQueries(GLsizei n, const GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glDeleteQueries;

        /// <summary>void glDeleteSamplers(GLsizei count, const GLuint* samplers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glDeleteSamplers;

        /// <summary>void glDeleteSync(GLsync sync)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, void> glDeleteSync;

        /// <summary>void glDeleteTransformFeedbacks(GLsizei n, const GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glDeleteTransformFeedbacks;

        /// <summary>void glDeleteVertexArrays(GLsizei n, const GLuint* arrays)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glDeleteVertexArrays;

        /// <summary>void glDrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instancecount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstanced;

        /// <summary>void glDrawBuffers(GLsizei n, const GLenum* bufs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, DrawBufferMode*, void> glDrawBuffers;

        /// <summary>void glDrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, const void* indices, GLsizei instancecount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, void> glDrawElementsInstanced;

        /// <summary>void glDrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const void* indices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, void> glDrawRangeElements;

        /// <summary>void glEndQuery(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, void> glEndQuery;

        /// <summary>void glEndTransformFeedback()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedback;

        /// <summary>GLsync glFenceSync(GLenum condition, GLbitfield flags)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, GLsync> glFenceSync;

        /// <summary>void glFlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRange;

        /// <summary>void glFramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, void> glFramebufferTextureLayer;

        /// <summary>void glGenQueries(GLsizei n, GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLquery*, void> glGenQueries;

        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glGenSamplers;

        /// <summary>void glGenTransformFeedbacks(GLsizei n, GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glGenTransformFeedbacks;

        /// <summary>void glGenVertexArrays(GLsizei n, GLuint* arrays)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glGenVertexArrays;

        /// <summary>void glGetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformBlockName;

        /// <summary>void glGetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, UniformBlockPName, GLint*, void> glGetActiveUniformBlockiv;

        /// <summary>void glGetActiveUniformsiv(GLuint program, GLsizei uniformCount, const GLuint* uniformIndices, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLuint*, UniformPName, GLint*, void> glGetActiveUniformsiv;

        /// <summary>void glGetBufferParameteri64v(GLenum target, GLenum pname, GLint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint64*, void> glGetBufferParameteri64v;

        /// <summary>void glGetBufferPointerv(GLenum target, GLenum pname, void** params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPointerNameARB, void**, void> glGetBufferPointerv;

        /// <summary>GLint glGetFragDataLocation(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataLocation;

        /// <summary>void glGetInteger64i_v(GLenum target, GLuint index, GLint64* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint64*, void> glGetInteger64i_v;

        /// <summary>void glGetInteger64v(GLenum pname, GLint64* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64v;

        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;

        /// <summary>void glGetInternalformativ(GLenum target, GLenum internalformat, GLenum pname, GLsizei count, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint*, void> glGetInternalformativ;

        /// <summary>void glGetProgramBinary(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinary;

        /// <summary>void glGetQueryObjectuiv(GLuint id, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint*, void> glGetQueryObjectuiv;

        /// <summary>void glGetQueryiv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, QueryParameterName, GLint*, void> glGetQueryiv;

        /// <summary>void glGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glGetSamplerParameterfv;

        /// <summary>void glGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameteriv;

        /// <summary>GLubyte* glGetStringi(GLenum name, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLuint, GLubyte*> glGetStringi;

        /// <summary>void glGetSynciv(GLsync sync, GLenum pname, GLsizei count, GLsizei* length, GLint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSynciv;

        /// <summary>void glGetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLsizei*, AttributeType*, GLchar*, void> glGetTransformFeedbackVarying;

        /// <summary>GLuint glGetUniformBlockIndex(GLuint program, const GLchar* uniformBlockName)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLuint> glGetUniformBlockIndex;

        /// <summary>void glGetUniformIndices(GLuint program, GLsizei uniformCount, const GLchar*const* uniformNames, GLuint* uniformIndices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, GLuint*, void> glGetUniformIndices;

        /// <summary>void glGetUniformuiv(GLuint program, GLint location, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint*, void> glGetUniformuiv;

        /// <summary>void glGetVertexAttribIiv(GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint*, void> glGetVertexAttribIiv;

        /// <summary>void glGetVertexAttribIuiv(GLuint index, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint*, void> glGetVertexAttribIuiv;

        /// <summary>void glInvalidateFramebuffer(GLenum target, GLsizei numAttachments, const GLenum* attachments)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glInvalidateFramebuffer;

        /// <summary>void glInvalidateSubFramebuffer(GLenum target, GLsizei numAttachments, const GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateSubFramebuffer;

        /// <summary>GLboolean glIsQuery(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLboolean> glIsQuery;

        /// <summary>GLboolean glIsSampler(GLuint sampler)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, GLboolean> glIsSampler;

        /// <summary>GLboolean glIsSync(GLsync sync)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, GLboolean> glIsSync;

        /// <summary>GLboolean glIsTransformFeedback(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, GLboolean> glIsTransformFeedback;

        /// <summary>GLboolean glIsVertexArray(GLuint array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLboolean> glIsVertexArray;

        /// <summary>void* glMapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapBufferRange;

        /// <summary>void glPauseTransformFeedback()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedback;

        /// <summary>void glProgramBinary(GLuint program, GLenum binaryFormat, const void* binary, GLsizei length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLenum, void*, GLsizei, void> glProgramBinary;

        /// <summary>void glProgramParameteri(GLuint program, GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramParameterPName, GLint, void> glProgramParameteri;

        /// <summary>void glReadBuffer(GLenum src)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReadBufferMode, void> glReadBuffer;

        /// <summary>void glRenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisample;

        /// <summary>void glResumeTransformFeedback()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedback;

        /// <summary>void glSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat, void> glSamplerParameterf;

        /// <summary>void glSamplerParameterfv(GLuint sampler, GLenum pname, const GLfloat* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glSamplerParameterfv;

        /// <summary>void glSamplerParameteri(GLuint sampler, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint, void> glSamplerParameteri;

        /// <summary>void glSamplerParameteriv(GLuint sampler, GLenum pname, const GLint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameteriv;

        /// <summary>void glTexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage3D;

        /// <summary>void glTexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2D;

        /// <summary>void glTexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTexStorage3D;

        /// <summary>void glTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage3D;

        /// <summary>void glTransformFeedbackVaryings(GLuint program, GLsizei count, const GLchar*const* varyings, GLenum bufferMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, TransformFeedbackBufferMode, void> glTransformFeedbackVaryings;

        /// <summary>void glUniform1ui(GLint location, GLuint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, void> glUniform1ui;

        /// <summary>void glUniform1uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform1uiv;

        /// <summary>void glUniform2ui(GLint location, GLuint v0, GLuint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, void> glUniform2ui;

        /// <summary>void glUniform2uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform2uiv;

        /// <summary>void glUniform3ui(GLint location, GLuint v0, GLuint v1, GLuint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, void> glUniform3ui;

        /// <summary>void glUniform3uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform3uiv;

        /// <summary>void glUniform4ui(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, GLuint, void> glUniform4ui;

        /// <summary>void glUniform4uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform4uiv;

        /// <summary>void glUniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, void> glUniformBlockBinding;

        /// <summary>void glUniformMatrix2x3fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x3fv;

        /// <summary>void glUniformMatrix2x4fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x4fv;

        /// <summary>void glUniformMatrix3x2fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x2fv;

        /// <summary>void glUniformMatrix3x4fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x4fv;

        /// <summary>void glUniformMatrix4x2fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x2fv;

        /// <summary>void glUniformMatrix4x3fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x3fv;

        /// <summary>GLboolean glUnmapBuffer(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLboolean> glUnmapBuffer;

        /// <summary>void glVertexAttribDivisor(GLuint index, GLuint divisor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisor;

        /// <summary>void glVertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, GLint, void> glVertexAttribI4i;

        /// <summary>void glVertexAttribI4iv(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI4iv;

        /// <summary>void glVertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI4ui;

        /// <summary>void glVertexAttribI4uiv(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI4uiv;

        /// <summary>void glVertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void*, void> glVertexAttribIPointer;

        /// <summary>void glWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncBehaviorFlags, GLuint64, void> glWaitSync;
    }
}
#endif