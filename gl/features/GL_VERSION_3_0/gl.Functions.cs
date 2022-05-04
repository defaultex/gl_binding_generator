#if (GL_VERSION_3_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBeginConditionalRender(GLuint id, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ConditionalRenderMode, void> glBeginConditionalRender;
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
        /// <summary>void glBindFragDataLocation(GLuint program, GLuint color, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLchar*, void> glBindFragDataLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindFramebuffer(GLenum target, GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, framebuffer, void> glBindFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindRenderbuffer(GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, renderbuffer, void> glBindRenderbuffer;
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
        /// <summary>GLenum glCheckFramebufferStatus(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferStatus> glCheckFramebufferStatus;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClampColor(GLenum target, GLenum clamp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClampColorTargetARB, ClampColorModeARB, void> glClampColor;
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
        /// <summary>void glColorMaski(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaski;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glDeleteFramebuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glDeleteRenderbuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glDeleteVertexArrays;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDisablei(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisablei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnablei(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnablei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEndConditionalRender();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRender;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEndTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRange;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, renderbuffer, void> glFramebufferRenderbuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTexture1D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, void> glFramebufferTexture1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, void> glFramebufferTexture2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTexture3D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, GLint, void> glFramebufferTexture3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, GLint, void> glFramebufferTextureLayer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenerateMipmap(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmap;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glGenFramebuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glGenRenderbuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, vertexarray*, void> glGenVertexArrays;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBooleani_v(GLenum target, GLuint index, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleani_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetFragDataLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetFragDataLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLubyte* glGetStringi(GLenum name, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLuint, GLubyte*> glGetStringi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexParameterIiv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexParameterIuiv(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLsizei*, AttributeType*, GLchar*, void> glGetTransformFeedbackVarying;
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
        /// <summary>GLboolean glIsEnabledi(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsFramebuffer(GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLboolean> glIsFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsRenderbuffer(GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, GLboolean> glIsRenderbuffer;
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
        /// <summary>void glRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisample;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameterIiv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameterIuiv(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuiv;
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
        /// <summary>void glVertexAttribI1i(GLuint index, GLint x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, void> glVertexAttribI1i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI1iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI1iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI1ui(GLuint index, GLuint x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribI1ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI1uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI1uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI2i(GLuint index, GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, void> glVertexAttribI2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI2iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI2ui(GLuint index, GLuint x, GLuint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glVertexAttribI2ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI2uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI2uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI3i(GLuint index, GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, void> glVertexAttribI3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI3iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI3ui(GLuint index, GLuint x, GLuint y, GLuint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI3uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI4bv(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttribI4bv;
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
        /// <summary>void glVertexAttribI4sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttribI4sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribI4ubv(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttribI4ubv;
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
        /// <summary>void glVertexAttribI4usv(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttribI4usv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void*, void> glVertexAttribIPointer;
#endif
    }
}
#endif