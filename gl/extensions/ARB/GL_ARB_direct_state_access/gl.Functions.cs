#if (GL_ARB_direct_state_access && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindTextureUnit(GLuint unit, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, texture, void> glBindTextureUnit;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBlitNamedFramebuffer(GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, framebuffer, GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, BlitFramebufferFilter, void> glBlitNamedFramebuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLenum glCheckNamedFramebufferStatus(GLuint framebuffer, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferTarget, FramebufferStatus> glCheckNamedFramebufferStatus;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glClearNamedBufferData(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearNamedBufferData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glClearNamedBufferSubData(GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, SizedInternalFormat, GLintptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearNamedBufferSubData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glClearNamedFramebufferfi(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, Buffer, GLint, GLfloat, GLint, void> glClearNamedFramebufferfi;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glClearNamedFramebufferfv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, Buffer, GLint, GLfloat*, void> glClearNamedFramebufferfv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glClearNamedFramebufferiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, Buffer, GLint, GLint*, void> glClearNamedFramebufferiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glClearNamedFramebufferuiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, Buffer, GLint, GLuint*, void> glClearNamedFramebufferuiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage1D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage2D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTextureSubImage3D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCopyNamedBufferSubData(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, buffer, GLintptr, GLintptr, GLsizeiptr, void> glCopyNamedBufferSubData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCopyTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTextureSubImage1D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCopyTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage2D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCopyTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTextureSubImage3D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, buffer*, void> glCreateBuffers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glCreateFramebuffers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateProgramPipelines(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, programpipeline*, void> glCreateProgramPipelines;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateQueries(GLenum target, GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLsizei, query*, void> glCreateQueries;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glCreateRenderbuffers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateSamplers(GLsizei n, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, sampler*, void> glCreateSamplers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateTextures(GLenum target, GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, texture*, void> glCreateTextures;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glCreateTransformFeedbacks;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glCreateVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glCreateVertexArrays;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDisableVertexArrayAttrib(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, void> glDisableVertexArrayAttrib;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glEnableVertexArrayAttrib(GLuint vaobj, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, void> glEnableVertexArrayAttrib;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glFlushMappedNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, void> glFlushMappedNamedBufferRange;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGenerateTextureMipmap(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, void> glGenerateTextureMipmap;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetCompressedTextureImage(GLuint texture, GLint level, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLsizei, void*, void> glGetCompressedTextureImage;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetNamedBufferParameteri64v(GLuint buffer, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferPNameARB, GLint64*, void> glGetNamedBufferParameteri64v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetNamedBufferParameteriv(GLuint buffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferPNameARB, GLint*, void> glGetNamedBufferParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetNamedBufferPointerv(GLuint buffer, GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferPointerNameARB, void**, void> glGetNamedBufferPointerv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetNamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, void*, void> glGetNamedBufferSubData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetNamedFramebufferAttachmentParameteriv(GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetNamedFramebufferAttachmentParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetNamedFramebufferParameteriv(GLuint framebuffer, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GetFramebufferParameter, GLint*, void> glGetNamedFramebufferParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetNamedRenderbufferParameteriv(GLuint renderbuffer, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, RenderbufferParameterName, GLint*, void> glGetNamedRenderbufferParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryBufferObjecti64v(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, buffer, QueryObjectParameterName, GLintptr, void> glGetQueryBufferObjecti64v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryBufferObjectiv(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, buffer, QueryObjectParameterName, GLintptr, void> glGetQueryBufferObjectiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryBufferObjectui64v(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, buffer, QueryObjectParameterName, GLintptr, void> glGetQueryBufferObjectui64v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryBufferObjectuiv(GLuint id, GLuint buffer, GLenum pname, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, buffer, QueryObjectParameterName, GLintptr, void> glGetQueryBufferObjectuiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTextureImage(GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, PixelFormat, PixelType, GLsizei, void*, void> glGetTextureImage;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTextureLevelParameterfv(GLuint texture, GLint level, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GetTextureParameter, GLfloat*, void> glGetTextureLevelParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTextureLevelParameteriv(GLuint texture, GLint level, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GetTextureParameter, GLint*, void> glGetTextureLevelParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTextureParameterfv(GLuint texture, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GetTextureParameter, GLfloat*, void> glGetTextureParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTextureParameterIiv(GLuint texture, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GetTextureParameter, GLint*, void> glGetTextureParameterIiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTextureParameterIuiv(GLuint texture, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GetTextureParameter, GLuint*, void> glGetTextureParameterIuiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTextureParameteriv(GLuint texture, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GetTextureParameter, GLint*, void> glGetTextureParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTransformFeedbacki_v(GLuint xfb, GLenum pname, GLuint index, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, TransformFeedbackPName, GLuint, GLint*, void> glGetTransformFeedbacki_v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTransformFeedbacki64_v(GLuint xfb, GLenum pname, GLuint index, GLint64* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, TransformFeedbackPName, GLuint, GLint64*, void> glGetTransformFeedbacki64_v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetTransformFeedbackiv(GLuint xfb, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, TransformFeedbackPName, GLint*, void> glGetTransformFeedbackiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexArrayIndexed64iv(GLuint vaobj, GLuint index, GLenum pname, GLint64* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, VertexArrayPName, GLint64*, void> glGetVertexArrayIndexed64iv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexArrayIndexediv(GLuint vaobj, GLuint index, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, VertexArrayPName, GLint*, void> glGetVertexArrayIndexediv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexArrayiv(GLuint vaobj, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, VertexArrayPName, GLint*, void> glGetVertexArrayiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateNamedFramebufferData(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLsizei, FramebufferAttachment*, void> glInvalidateNamedFramebufferData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateNamedFramebufferSubData(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLsizei, FramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateNamedFramebufferSubData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void* glMapNamedBuffer(GLuint buffer, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferAccessARB, void*> glMapNamedBuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void* glMapNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapNamedBufferRange;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedBufferData(GLuint buffer, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLsizeiptr, void*, VertexBufferObjectUsage, void> glNamedBufferData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedBufferStorage(GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLsizeiptr, void*, BufferStorageMask, void> glNamedBufferStorage;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, void*, void> glNamedBufferSubData;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedFramebufferDrawBuffer(GLuint framebuffer, GLenum buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, ColorBuffer, void> glNamedFramebufferDrawBuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedFramebufferDrawBuffers(GLuint framebuffer, GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLsizei, ColorBuffer*, void> glNamedFramebufferDrawBuffers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedFramebufferParameteri(GLuint framebuffer, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferParameterName, GLint, void> glNamedFramebufferParameteri;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedFramebufferReadBuffer(GLuint framebuffer, GLenum src);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, ColorBuffer, void> glNamedFramebufferReadBuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedFramebufferRenderbuffer(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, RenderbufferTarget, renderbuffer, void> glNamedFramebufferRenderbuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedFramebufferTexture(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, texture, GLint, void> glNamedFramebufferTexture;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedFramebufferTextureLayer(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, FramebufferAttachment, texture, GLint, GLint, void> glNamedFramebufferTextureLayer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedRenderbufferStorage(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorage;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNamedRenderbufferStorageMultisample(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, GLsizei, InternalFormat, GLsizei, GLsizei, void> glNamedRenderbufferStorageMultisample;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureBuffer(GLuint texture, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, SizedInternalFormat, buffer, void> glTextureBuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureBufferRange(GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, SizedInternalFormat, buffer, GLintptr, GLsizeiptr, void> glTextureBufferRange;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureParameterf(GLuint texture, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureParameterName, GLfloat, void> glTextureParameterf;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureParameterfv(GLuint texture, GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureParameterName, GLfloat*, void> glTextureParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureParameteri(GLuint texture, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureParameterName, GLint, void> glTextureParameteri;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureParameterIiv(GLuint texture, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureParameterName, GLint*, void> glTextureParameterIiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureParameterIuiv(GLuint texture, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureParameterName, GLuint*, void> glTextureParameterIuiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureParameteriv(GLuint texture, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureParameterName, GLint*, void> glTextureParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureStorage1D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, void> glTextureStorage1D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureStorage2D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTextureStorage2D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureStorage2DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTextureStorage2DMultisample;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureStorage3D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTextureStorage3D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureStorage3DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTextureStorage3DMultisample;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage1D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage2D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTextureSubImage3D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTransformFeedbackBufferBase(GLuint xfb, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, GLuint, buffer, void> glTransformFeedbackBufferBase;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTransformFeedbackBufferRange(GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, GLuint, buffer, GLintptr, GLsizeiptr, void> glTransformFeedbackBufferRange;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLboolean glUnmapNamedBuffer(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLboolean> glUnmapNamedBuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayAttribBinding(GLuint vaobj, GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLuint, void> glVertexArrayAttribBinding;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayAttribFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexArrayAttribFormat;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayAttribIFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLint, VertexAttribIType, GLuint, void> glVertexArrayAttribIFormat;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayAttribLFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLint, VertexAttribLType, GLuint, void> glVertexArrayAttribLFormat;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayBindingDivisor(GLuint vaobj, GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLuint, void> glVertexArrayBindingDivisor;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayElementBuffer(GLuint vaobj, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, buffer, void> glVertexArrayElementBuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayVertexBuffer(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, buffer, GLintptr, GLsizei, void> glVertexArrayVertexBuffer;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexArrayVertexBuffers(GLuint vaobj, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<vertexarray, GLuint, GLsizei, buffer*, GLintptr*, GLsizei*, void> glVertexArrayVertexBuffers;
#endif
    }
}
#endif