public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBindTextureUnit(GLuint unit, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLtexture, void> glBindTextureUnit;

        /// <summary>void glBlitNamedFramebuffer(GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLframebuffer, GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, MagFilter, void> glBlitNamedFramebuffer;

        /// <summary>GLenum glCheckNamedFramebufferStatus(GLuint framebuffer, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferTarget, FramebufferStatus> glCheckNamedFramebufferStatus;

        /// <summary>void glClearNamedBufferData(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearNamedBufferData;

        /// <summary>void glClearNamedBufferSubData(GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, SizedInternalFormat, GLintptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearNamedBufferSubData;

        /// <summary>void glClearNamedFramebufferfi(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, Buffer, GLint, GLfloat, GLint, void> glClearNamedFramebufferfi;

        /// <summary>void glClearNamedFramebufferfv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, Buffer, GLint, GLfloat*, void> glClearNamedFramebufferfv;

        /// <summary>void glClearNamedFramebufferiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, Buffer, GLint, GLint*, void> glClearNamedFramebufferiv;

        /// <summary>void glClearNamedFramebufferuiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, Buffer, GLint, GLuint*, void> glClearNamedFramebufferuiv;

        /// <summary>void glClipControl(GLenum origin, GLenum depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipControlOrigin, ClipControlDepth, void> glClipControl;

        /// <summary>void glCompressedTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage1D;

        /// <summary>void glCompressedTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage2D;

        /// <summary>void glCompressedTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage3D;

        /// <summary>void glCopyNamedBufferSubData(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLbuffer, GLintptr, GLintptr, GLsizeiptr, void> glCopyNamedBufferSubData;

        /// <summary>void glCopyTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTextureSubImage1D;

        /// <summary>void glCopyTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage2D;

        /// <summary>void glCopyTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage3D;

        /// <summary>void glCreateBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glCreateBuffers;

        /// <summary>void glCreateFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glCreateFramebuffers;

        /// <summary>void glCreateProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogrampipeline*, void> glCreateProgramPipelines;

        /// <summary>void glCreateQueries(GLenum target, GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLsizei, GLquery*, void> glCreateQueries;

        /// <summary>void glCreateRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glCreateRenderbuffers;

        /// <summary>void glCreateSamplers(GLsizei n, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glCreateSamplers;

        /// <summary>void glCreateTextures(GLenum target, GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLtexture*, void> glCreateTextures;

        /// <summary>void glCreateTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glCreateTransformFeedbacks;

        /// <summary>void glCreateVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glCreateVertexArrays;

        /// <summary>void glDisableVertexArrayAttrib(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, void> glDisableVertexArrayAttrib;

        /// <summary>void glEnableVertexArrayAttrib(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, void> glEnableVertexArrayAttrib;

        /// <summary>void glFlushMappedNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void> glFlushMappedNamedBufferRange;

        /// <summary>void glGenerateTextureMipmap(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, void> glGenerateTextureMipmap;

        /// <summary>void glGetCompressedTextureImage(GLuint texture, GLint level, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLsizei, void*, void> glGetCompressedTextureImage;

        /// <summary>void glGetCompressedTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLsizei, void*, void> glGetCompressedTextureSubImage;

        /// <summary>GLenum glGetGraphicsResetStatus();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatus;

        /// <summary>void glGetNamedBufferParameteri64v(GLuint buffer, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferParameter, GLint64*, void> glGetNamedBufferParameteri64v;

        /// <summary>void glGetNamedBufferParameteriv(GLuint buffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferParameter, GLint*, void> glGetNamedBufferParameteriv;

        /// <summary>void glGetNamedBufferPointerv(GLuint buffer, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferPointerParameter, void**, void> glGetNamedBufferPointerv;

        /// <summary>void glGetNamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void*, void> glGetNamedBufferSubData;

        /// <summary>void glGetNamedFramebufferAttachmentParameteriv(GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, FramebufferAttachmentParameter, GLint*, void> glGetNamedFramebufferAttachmentParameteriv;

        /// <summary>void glGetNamedFramebufferParameteriv(GLuint framebuffer, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferParameter, GLint*, void> glGetNamedFramebufferParameteriv;

        /// <summary>void glGetNamedRenderbufferParameteriv(GLuint renderbuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, RenderbufferParameter, GLint*, void> glGetNamedRenderbufferParameteriv;

        /// <summary>void glGetnCompressedTexImage(GLenum target, GLint lod, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLsizei, void*, void> glGetnCompressedTexImage;

        /// <summary>void glGetnTexImage(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, GLsizei, void*, void> glGetnTexImage;

        /// <summary>void glGetnUniformdv(GLuint program, GLint location, GLsizei bufSize, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glGetnUniformdv;

        /// <summary>void glGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfv;

        /// <summary>void glGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformiv;

        /// <summary>void glGetnUniformuiv(GLuint program, GLint location, GLsizei bufSize, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glGetnUniformuiv;

        /// <summary>void glGetQueryBufferObjecti64v(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLbuffer, QueryObjectParameter, GLintptr, void> glGetQueryBufferObjecti64v;

        /// <summary>void glGetQueryBufferObjectiv(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLbuffer, QueryObjectParameter, GLintptr, void> glGetQueryBufferObjectiv;

        /// <summary>void glGetQueryBufferObjectui64v(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLbuffer, QueryObjectParameter, GLintptr, void> glGetQueryBufferObjectui64v;

        /// <summary>void glGetQueryBufferObjectuiv(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, GLbuffer, QueryObjectParameter, GLintptr, void> glGetQueryBufferObjectuiv;

        /// <summary>void glGetTextureImage(GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, PixelFormat, PixelType, GLsizei, void*, void> glGetTextureImage;

        /// <summary>void glGetTextureLevelParameterfv(GLuint texture, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, TextureParameter, GLfloat*, void> glGetTextureLevelParameterfv;

        /// <summary>void glGetTextureLevelParameteriv(GLuint texture, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, TextureParameter, GLint*, void> glGetTextureLevelParameteriv;

        /// <summary>void glGetTextureParameterfv(GLuint texture, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLfloat*, void> glGetTextureParameterfv;

        /// <summary>void glGetTextureParameterIiv(GLuint texture, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLint*, void> glGetTextureParameterIiv;

        /// <summary>void glGetTextureParameterIuiv(GLuint texture, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLuint*, void> glGetTextureParameterIuiv;

        /// <summary>void glGetTextureParameteriv(GLuint texture, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLint*, void> glGetTextureParameteriv;

        /// <summary>void glGetTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glGetTextureSubImage;

        /// <summary>void glGetTransformFeedbacki_v(GLuint xfb, GLenum pname, GLuint index, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, TransformFeedbackParameter, GLuint, GLint*, void> glGetTransformFeedbacki_v;

        /// <summary>void glGetTransformFeedbacki64_v(GLuint xfb, GLenum pname, GLuint index, GLint64* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, TransformFeedbackParameter, GLuint, GLint64*, void> glGetTransformFeedbacki64_v;

        /// <summary>void glGetTransformFeedbackiv(GLuint xfb, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, TransformFeedbackParameter, GLint*, void> glGetTransformFeedbackiv;

        /// <summary>void glGetVertexArrayIndexed64iv(GLuint vaobj, GLuint index, GLenum pname, GLint64* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, VertexArrayParameter, GLint64*, void> glGetVertexArrayIndexed64iv;

        /// <summary>void glGetVertexArrayIndexediv(GLuint vaobj, GLuint index, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, VertexArrayParameter, GLint*, void> glGetVertexArrayIndexediv;

        /// <summary>void glGetVertexArrayiv(GLuint vaobj, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, VertexArrayParameter, GLint*, void> glGetVertexArrayiv;

        /// <summary>void glInvalidateNamedFramebufferData(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLsizei, FramebufferAttachment*, void> glInvalidateNamedFramebufferData;

        /// <summary>void glInvalidateNamedFramebufferSubData(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLsizei, FramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateNamedFramebufferSubData;

        /// <summary>void* glMapNamedBuffer(GLuint buffer, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferAccess, void*> glMapNamedBuffer;

        /// <summary>void* glMapNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapNamedBufferRange;

        /// <summary>void glMemoryBarrierByRegion(GLbitfield barriers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrierByRegion;

        /// <summary>void glNamedBufferData(GLuint buffer, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLsizeiptr, void*, BufferUsage, void> glNamedBufferData;

        /// <summary>void glNamedBufferStorage(GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLsizeiptr, void*, BufferStorageMask, void> glNamedBufferStorage;

        /// <summary>void glNamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void*, void> glNamedBufferSubData;

        /// <summary>void glNamedFramebufferDrawBuffer(GLuint framebuffer, GLenum buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, ColorBuffer, void> glNamedFramebufferDrawBuffer;

        /// <summary>void glNamedFramebufferDrawBuffers(GLuint framebuffer, GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLsizei, ColorBuffer*, void> glNamedFramebufferDrawBuffers;

        /// <summary>void glNamedFramebufferParameteri(GLuint framebuffer, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferParameter, GLint, void> glNamedFramebufferParameteri;

        /// <summary>void glNamedFramebufferReadBuffer(GLuint framebuffer, GLenum src);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, ColorBuffer, void> glNamedFramebufferReadBuffer;

        /// <summary>void glNamedFramebufferRenderbuffer(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glNamedFramebufferRenderbuffer;

        /// <summary>void glNamedFramebufferTexture(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, GLtexture, GLint, void> glNamedFramebufferTexture;

        /// <summary>void glNamedFramebufferTextureLayer(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, FramebufferAttachment, GLtexture, GLint, GLint, void> glNamedFramebufferTextureLayer;

        /// <summary>void glNamedRenderbufferStorage(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorage;

        /// <summary>void glNamedRenderbufferStorageMultisample(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisample;

        /// <summary>void glReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixels;

        /// <summary>void glTextureBarrier();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTextureBarrier;

        /// <summary>void glTextureBuffer(GLuint texture, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, SizedInternalFormat, GLbuffer, void> glTextureBuffer;

        /// <summary>void glTextureBufferRange(GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, SizedInternalFormat, GLbuffer, GLintptr, GLsizeiptr, void> glTextureBufferRange;

        /// <summary>void glTextureParameterf(GLuint texture, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLfloat, void> glTextureParameterf;

        /// <summary>void glTextureParameterfv(GLuint texture, GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLfloat*, void> glTextureParameterfv;

        /// <summary>void glTextureParameteri(GLuint texture, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLint, void> glTextureParameteri;

        /// <summary>void glTextureParameterIiv(GLuint texture, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLint*, void> glTextureParameterIiv;

        /// <summary>void glTextureParameterIuiv(GLuint texture, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLuint*, void> glTextureParameterIuiv;

        /// <summary>void glTextureParameteriv(GLuint texture, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureParameter, GLint*, void> glTextureParameteriv;

        /// <summary>void glTextureStorage1D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, void> glTextureStorage1D;

        /// <summary>void glTextureStorage2D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTextureStorage2D;

        /// <summary>void glTextureStorage2DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureStorage2DMultisample;

        /// <summary>void glTextureStorage3D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTextureStorage3D;

        /// <summary>void glTextureStorage3DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureStorage3DMultisample;

        /// <summary>void glTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage1D;

        /// <summary>void glTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage2D;

        /// <summary>void glTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage3D;

        /// <summary>void glTransformFeedbackBufferBase(GLuint xfb, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, GLuint, GLbuffer, void> glTransformFeedbackBufferBase;

        /// <summary>void glTransformFeedbackBufferRange(GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glTransformFeedbackBufferRange;

        /// <summary>GLboolean glUnmapNamedBuffer(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glUnmapNamedBuffer;

        /// <summary>void glVertexArrayAttribBinding(GLuint vaobj, GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLuint, void> glVertexArrayAttribBinding;

        /// <summary>void glVertexArrayAttribFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexArrayAttribFormat;

        /// <summary>void glVertexArrayAttribIFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLint, VertexAttribType, GLuint, void> glVertexArrayAttribIFormat;

        /// <summary>void glVertexArrayAttribLFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLint, VertexAttribType, GLuint, void> glVertexArrayAttribLFormat;

        /// <summary>void glVertexArrayBindingDivisor(GLuint vaobj, GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLuint, void> glVertexArrayBindingDivisor;

        /// <summary>void glVertexArrayElementBuffer(GLuint vaobj, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLbuffer, void> glVertexArrayElementBuffer;

        /// <summary>void glVertexArrayVertexBuffer(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLbuffer, GLintptr, GLsizei, void> glVertexArrayVertexBuffer;

        /// <summary>void glVertexArrayVertexBuffers(GLuint vaobj, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLuint, GLsizei, GLbuffer*, GLintptr*, GLsizei*, void> glVertexArrayVertexBuffers;
    }
}
