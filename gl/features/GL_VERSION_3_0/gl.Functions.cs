#if (GL_VERSION_3_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginConditionalRender(GLuint id, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ConditionalRenderMode, void> glBeginConditionalRender;

        /// <summary>void glBeginTransformFeedback(GLenum primitiveMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedback;

        /// <summary>void glBindBufferBase(GLenum target, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, void> glBindBufferBase;

        /// <summary>void glBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glBindBufferRange;

        /// <summary>void glBindFragDataLocation(GLuint program, GLuint color, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLchar*, void> glBindFragDataLocation;

        /// <summary>void glBindFramebuffer(GLenum target, GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLframebuffer, void> glBindFramebuffer;

        /// <summary>void glBindRenderbuffer(GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLrenderbuffer, void> glBindRenderbuffer;

        /// <summary>void glBindVertexArray(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, void> glBindVertexArray;

        /// <summary>void glBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, BlitFramebufferFilter, void> glBlitFramebuffer;

        /// <summary>GLenum glCheckFramebufferStatus(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferStatus> glCheckFramebufferStatus;

        /// <summary>void glClampColor(GLenum target, GLenum clamp);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClampColorTargetARB, ClampColorModeARB, void> glClampColor;

        /// <summary>void glClearBufferfi(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat, GLint, void> glClearBufferfi;

        /// <summary>void glClearBufferfv(GLenum buffer, GLint drawbuffer, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat*, void> glClearBufferfv;

        /// <summary>void glClearBufferiv(GLenum buffer, GLint drawbuffer, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLint*, void> glClearBufferiv;

        /// <summary>void glClearBufferuiv(GLenum buffer, GLint drawbuffer, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLuint*, void> glClearBufferuiv;

        /// <summary>void glColorMaski(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaski;

        /// <summary>void glDeleteFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glDeleteFramebuffers;

        /// <summary>void glDeleteRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glDeleteRenderbuffers;

        /// <summary>void glDeleteVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glDeleteVertexArrays;

        /// <summary>void glDisablei(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisablei;

        /// <summary>void glEnablei(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnablei;

        /// <summary>void glEndConditionalRender();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRender;

        /// <summary>void glEndTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedback;

        /// <summary>void glFlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRange;

        /// <summary>void glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glFramebufferRenderbuffer;

        /// <summary>void glFramebufferTexture1D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture1D;

        /// <summary>void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture2D;

        /// <summary>void glFramebufferTexture3D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, GLint, void> glFramebufferTexture3D;

        /// <summary>void glFramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, void> glFramebufferTextureLayer;

        /// <summary>void glGenerateMipmap(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmap;

        /// <summary>void glGenFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glGenFramebuffers;

        /// <summary>void glGenRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glGenRenderbuffers;

        /// <summary>void glGenVertexArrays(GLsizei n, GLuint* arrays);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glGenVertexArrays;

        /// <summary>void glGetBooleani_v(GLenum target, GLuint index, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleani_v;

        /// <summary>GLint glGetFragDataLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataLocation;

        /// <summary>void glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameteriv;

        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;

        /// <summary>void glGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameteriv;

        /// <summary>GLubyte* glGetStringi(GLenum name, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLuint, GLubyte*> glGetStringi;

        /// <summary>void glGetTexParameterIiv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIiv;

        /// <summary>void glGetTexParameterIuiv(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuiv;

        /// <summary>void glGetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLsizei*, AttributeType*, GLchar*, void> glGetTransformFeedbackVarying;

        /// <summary>void glGetUniformuiv(GLuint program, GLint location, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint*, void> glGetUniformuiv;

        /// <summary>void glGetVertexAttribIiv(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint*, void> glGetVertexAttribIiv;

        /// <summary>void glGetVertexAttribIuiv(GLuint index, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint*, void> glGetVertexAttribIuiv;

        /// <summary>GLboolean glIsEnabledi(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledi;

        /// <summary>GLboolean glIsFramebuffer(GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLboolean> glIsFramebuffer;

        /// <summary>GLboolean glIsRenderbuffer(GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLboolean> glIsRenderbuffer;

        /// <summary>GLboolean glIsVertexArray(GLuint array);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLboolean> glIsVertexArray;

        /// <summary>void* glMapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapBufferRange;

        /// <summary>void glRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorage;

        /// <summary>void glRenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisample;

        /// <summary>void glTexParameterIiv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIiv;

        /// <summary>void glTexParameterIuiv(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuiv;

        /// <summary>void glTransformFeedbackVaryings(GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, TransformFeedbackBufferMode, void> glTransformFeedbackVaryings;

        /// <summary>void glUniform1ui(GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, void> glUniform1ui;

        /// <summary>void glUniform1uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform1uiv;

        /// <summary>void glUniform2ui(GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, void> glUniform2ui;

        /// <summary>void glUniform2uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform2uiv;

        /// <summary>void glUniform3ui(GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, void> glUniform3ui;

        /// <summary>void glUniform3uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform3uiv;

        /// <summary>void glUniform4ui(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, GLuint, void> glUniform4ui;

        /// <summary>void glUniform4uiv(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform4uiv;

        /// <summary>void glVertexAttribI1i(GLuint index, GLint x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, void> glVertexAttribI1i;

        /// <summary>void glVertexAttribI1iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI1iv;

        /// <summary>void glVertexAttribI1ui(GLuint index, GLuint x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribI1ui;

        /// <summary>void glVertexAttribI1uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI1uiv;

        /// <summary>void glVertexAttribI2i(GLuint index, GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, void> glVertexAttribI2i;

        /// <summary>void glVertexAttribI2iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI2iv;

        /// <summary>void glVertexAttribI2ui(GLuint index, GLuint x, GLuint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glVertexAttribI2ui;

        /// <summary>void glVertexAttribI2uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI2uiv;

        /// <summary>void glVertexAttribI3i(GLuint index, GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, void> glVertexAttribI3i;

        /// <summary>void glVertexAttribI3iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI3iv;

        /// <summary>void glVertexAttribI3ui(GLuint index, GLuint x, GLuint y, GLuint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI3ui;

        /// <summary>void glVertexAttribI3uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI3uiv;

        /// <summary>void glVertexAttribI4bv(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttribI4bv;

        /// <summary>void glVertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, GLint, void> glVertexAttribI4i;

        /// <summary>void glVertexAttribI4iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI4iv;

        /// <summary>void glVertexAttribI4sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttribI4sv;

        /// <summary>void glVertexAttribI4ubv(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttribI4ubv;

        /// <summary>void glVertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI4ui;

        /// <summary>void glVertexAttribI4uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI4uiv;

        /// <summary>void glVertexAttribI4usv(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttribI4usv;

        /// <summary>void glVertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void*, void> glVertexAttribIPointer;
    }
}
#endif