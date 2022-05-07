#if (GL_SC_VERSION_2_0 && GLSC2_API)
public partial class glsc2 { 
    public partial class Functions { 
        /// <summary>void glActiveTexture(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;

        /// <summary>void glBindBuffer(GLenum target, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLbuffer, void> glBindBuffer;

        /// <summary>void glBindFramebuffer(GLenum target, GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLframebuffer, void> glBindFramebuffer;

        /// <summary>void glBindRenderbuffer(GLenum target, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLrenderbuffer, void> glBindRenderbuffer;

        /// <summary>void glBindTexture(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;

        /// <summary>void glBlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;

        /// <summary>void glBlendEquation(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquation;

        /// <summary>void glBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparate;

        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;

        /// <summary>void glBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;

        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, void*, BufferUsageARB, void> glBufferData;

        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glBufferSubData;

        /// <summary>GLenum glCheckFramebufferStatus(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferStatus> glCheckFramebufferStatus;

        /// <summary>void glClear(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;

        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;

        /// <summary>void glClearDepthf(GLfloat d);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;

        /// <summary>void glClearStencil(GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;

        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;

        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;

        /// <summary>GLuint glCreateProgram();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram> glCreateProgram;

        /// <summary>void glCullFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;

        /// <summary>void glDepthFunc(GLenum func);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;

        /// <summary>void glDepthMask(GLboolean flag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;

        /// <summary>void glDepthRangef(GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;

        /// <summary>void glDisable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;

        /// <summary>void glDisableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArray;

        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;

        /// <summary>void glDrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, void> glDrawRangeElements;

        /// <summary>void glEnable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;

        /// <summary>void glEnableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArray;

        /// <summary>void glFinish();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;

        /// <summary>void glFlush();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;

        /// <summary>void glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glFramebufferRenderbuffer;

        /// <summary>void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture2D;

        /// <summary>void glFrontFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;

        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffers;

        /// <summary>void glGenerateMipmap(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmap;

        /// <summary>void glGenFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glGenFramebuffers;

        /// <summary>void glGenRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glGenRenderbuffers;

        /// <summary>void glGenTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;

        /// <summary>GLint glGetAttribLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetAttribLocation;

        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;

        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameteriv;

        /// <summary>GLenum glGetError();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ErrorCode> glGetError;

        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;

        /// <summary>void glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameteriv;

        /// <summary>GLenum glGetGraphicsResetStatus();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatus;

        /// <summary>void glGetIntegerv(GLenum pname, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;

        /// <summary>void glGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfv;

        /// <summary>void glGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformiv;

        /// <summary>void glGetProgramiv(GLuint program, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramPropertyARB, GLint*, void> glGetProgramiv;

        /// <summary>void glGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameteriv;

        /// <summary>GLubyte* glGetString(GLenum name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;

        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;

        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;

        /// <summary>GLint glGetUniformLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetUniformLocation;

        /// <summary>void glGetVertexAttribfv(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfv;

        /// <summary>void glGetVertexAttribiv(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribiv;

        /// <summary>void glGetVertexAttribPointerv(GLuint index, GLenum pname, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointerv;

        /// <summary>void glHint(GLenum target, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;

        /// <summary>GLboolean glIsEnabled(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;

        /// <summary>void glLineWidth(GLfloat width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;

        /// <summary>void glPixelStorei(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;

        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;

        /// <summary>void glProgramBinary(GLuint program, GLenum binaryFormat, void* binary, GLsizei length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLenum, void*, GLsizei, void> glProgramBinary;

        /// <summary>void glReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixels;

        /// <summary>void glRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorage;

        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;

        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;

        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;

        /// <summary>void glStencilFuncSeparate(GLenum face, GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilFunction, GLint, GLuint, void> glStencilFuncSeparate;

        /// <summary>void glStencilMask(GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;

        /// <summary>void glStencilMaskSeparate(GLenum face, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilMaskSeparate;

        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;

        /// <summary>void glStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparate;

        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;

        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;

        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;

        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;

        /// <summary>void glTexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2D;

        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;

        /// <summary>void glUniform1f(GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1f;

        /// <summary>void glUniform1fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fv;

        /// <summary>void glUniform1i(GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1i;

        /// <summary>void glUniform1iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1iv;

        /// <summary>void glUniform2f(GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2f;

        /// <summary>void glUniform2fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fv;

        /// <summary>void glUniform2i(GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2i;

        /// <summary>void glUniform2iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2iv;

        /// <summary>void glUniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3f;

        /// <summary>void glUniform3fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fv;

        /// <summary>void glUniform3i(GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3i;

        /// <summary>void glUniform3iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3iv;

        /// <summary>void glUniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4f;

        /// <summary>void glUniform4fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fv;

        /// <summary>void glUniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4i;

        /// <summary>void glUniform4iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4iv;

        /// <summary>void glUniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fv;

        /// <summary>void glUniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fv;

        /// <summary>void glUniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fv;

        /// <summary>void glUseProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glUseProgram;

        /// <summary>void glVertexAttrib1f(GLuint index, GLfloat x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1f;

        /// <summary>void glVertexAttrib1fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fv;

        /// <summary>void glVertexAttrib2f(GLuint index, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2f;

        /// <summary>void glVertexAttrib2fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fv;

        /// <summary>void glVertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3f;

        /// <summary>void glVertexAttrib3fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fv;

        /// <summary>void glVertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4f;

        /// <summary>void glVertexAttrib4fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fv;

        /// <summary>void glVertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointer;

        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;
    }
}
#endif