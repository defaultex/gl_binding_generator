#if (GL_SC_VERSION_2_0 && GLSC2_API)
public partial class glsc2 { 
    public partial class Functions { 
#if !GL_ES_VERSION_2_0

        /// <summary>void glActiveTexture(GLenum texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBindBuffer(GLenum target, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLbuffer, void> glBindBuffer;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBindFramebuffer(GLenum target, GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLframebuffer, void> glBindFramebuffer;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBindRenderbuffer(GLenum target, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLrenderbuffer, void> glBindRenderbuffer;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBindTexture(GLenum target, GLuint texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBlendEquation(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquation;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparate;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, const void* data, GLenum usage)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, void*, BufferUsageARB, void> glBufferData;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glBufferSubData;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLenum glCheckFramebufferStatus(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLenum> glCheckFramebufferStatus;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glClear(GLbitfield mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glClearDepthf(GLfloat d)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glClearStencil(GLint s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLuint glCreateProgram()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint> glCreateProgram;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glCullFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDepthFunc(GLenum func)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDepthMask(GLboolean flag)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDepthRangef(GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDisable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDisableVertexAttribArray(GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArray;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glDrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const void* indices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, void> glDrawRangeElements;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glEnable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glEnableVertexAttribArray(GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArray;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glFinish()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glFlush()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glFramebufferRenderbuffer;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture2D;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glFrontFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffers;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGenFramebuffers(GLsizei n, GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glGenFramebuffers;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGenRenderbuffers(GLsizei n, GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glGenRenderbuffers;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGenTextures(GLsizei n, GLuint* textures)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGenerateMipmap(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmap;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLint glGetAttribLocation(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetAttribLocation;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameteriv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLenum glGetError()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetError;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameteriv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>GLenum glGetGraphicsResetStatus()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetGraphicsResetStatus;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetIntegerv(GLenum pname, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetProgramiv(GLuint program, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramPropertyARB, GLint*, void> glGetProgramiv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameteriv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLubyte* glGetString(GLenum name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLint glGetUniformLocation(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetUniformLocation;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetVertexAttribPointerv(GLuint index, GLenum pname, void** pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointerv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetVertexAttribfv(GLuint index, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glGetVertexAttribiv(GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribiv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformiv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glHint(GLenum target, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLboolean glIsEnabled(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glLineWidth(GLfloat width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glPixelStorei(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glProgramBinary(GLuint program, GLenum binaryFormat, const void* binary, GLsizei length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLenum, void*, GLsizei, void> glProgramBinary;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixels;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorage;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glStencilFuncSeparate(GLenum face, GLenum func, GLint ref, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilFunction, GLint, GLuint, void> glStencilFuncSeparate;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glStencilMask(GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glStencilMaskSeparate(GLenum face, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilMaskSeparate;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparate;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glTexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2D;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform1f(GLint location, GLfloat v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform1fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform1i(GLint location, GLint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1i;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform1iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1iv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform2f(GLint location, GLfloat v0, GLfloat v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform2fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform2i(GLint location, GLint v0, GLint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2i;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform2iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2iv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform3fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform3i(GLint location, GLint v0, GLint v1, GLint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3i;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform3iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3iv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform4fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4i;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniform4iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4iv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glUseProgram(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glUseProgram;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib1f(GLuint index, GLfloat x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib1fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib2f(GLuint index, GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib2fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib3fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4f;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttrib4fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fv;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glVertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointer;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;

#endif
    }
}
#endif