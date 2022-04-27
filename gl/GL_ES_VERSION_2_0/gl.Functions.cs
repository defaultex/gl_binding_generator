#if (GL_ES_VERSION_2_0 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glActiveTexture(GLenum texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;

        /// <summary>void glAttachShader(GLuint program, GLuint shader)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLshader, void> glAttachShader;

        /// <summary>void glBindAttribLocation(GLuint program, GLuint index, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLchar*, void> glBindAttribLocation;

        /// <summary>void glBindBuffer(GLenum target, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLbuffer, void> glBindBuffer;

        /// <summary>void glBindFramebuffer(GLenum target, GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLframebuffer, void> glBindFramebuffer;

        /// <summary>void glBindRenderbuffer(GLenum target, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLrenderbuffer, void> glBindRenderbuffer;

        /// <summary>void glBindTexture(GLenum target, GLuint texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;

        /// <summary>void glBlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;

        /// <summary>void glBlendEquation(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquation;

        /// <summary>void glBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparate;

        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;

        /// <summary>void glBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;

        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, const void* data, GLenum usage)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, void*, BufferUsageARB, void> glBufferData;

        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glBufferSubData;

        /// <summary>GLenum glCheckFramebufferStatus(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLenum> glCheckFramebufferStatus;

        /// <summary>void glClear(GLbitfield mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;

        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;

        /// <summary>void glClearDepthf(GLfloat d)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;

        /// <summary>void glClearStencil(GLint s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;

        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;

        /// <summary>void glCompileShader(GLuint shader)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, void> glCompileShader;

        /// <summary>void glCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;

        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;

        /// <summary>void glCopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;

        /// <summary>void glCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;

        /// <summary>GLuint glCreateProgram()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint> glCreateProgram;

        /// <summary>GLuint glCreateShader(GLenum type)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLuint> glCreateShader;

        /// <summary>void glCullFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;

        /// <summary>void glDeleteBuffers(GLsizei n, const GLuint* buffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glDeleteBuffers;

        /// <summary>void glDeleteFramebuffers(GLsizei n, const GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glDeleteFramebuffers;

        /// <summary>void glDeleteProgram(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glDeleteProgram;

        /// <summary>void glDeleteRenderbuffers(GLsizei n, const GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glDeleteRenderbuffers;

        /// <summary>void glDeleteShader(GLuint shader)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, void> glDeleteShader;

        /// <summary>void glDeleteTextures(GLsizei n, const GLuint* textures)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glDeleteTextures;

        /// <summary>void glDepthFunc(GLenum func)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;

        /// <summary>void glDepthMask(GLboolean flag)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;

        /// <summary>void glDepthRangef(GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;

        /// <summary>void glDetachShader(GLuint program, GLuint shader)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLshader, void> glDetachShader;

        /// <summary>void glDisable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;

        /// <summary>void glDisableVertexAttribArray(GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArray;

        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;

        /// <summary>void glDrawElements(GLenum mode, GLsizei count, GLenum type, const void* indices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, void> glDrawElements;

        /// <summary>void glEnable(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;

        /// <summary>void glEnableVertexAttribArray(GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArray;

        /// <summary>void glFinish()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;

        /// <summary>void glFlush()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;

        /// <summary>void glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glFramebufferRenderbuffer;

        /// <summary>void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture2D;

        /// <summary>void glFrontFace(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;

        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLbuffer*, void> glGenBuffers;

        /// <summary>void glGenFramebuffers(GLsizei n, GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glGenFramebuffers;

        /// <summary>void glGenRenderbuffers(GLsizei n, GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glGenRenderbuffers;

        /// <summary>void glGenTextures(GLsizei n, GLuint* textures)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;

        /// <summary>void glGenerateMipmap(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmap;

        /// <summary>void glGetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLint*, AttributeType*, GLchar*, void> glGetActiveAttrib;

        /// <summary>void glGetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLint*, UniformType*, GLchar*, void> glGetActiveUniform;

        /// <summary>void glGetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLshader*, void> glGetAttachedShaders;

        /// <summary>GLint glGetAttribLocation(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetAttribLocation;

        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;

        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameteriv;

        /// <summary>GLenum glGetError()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetError;

        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;

        /// <summary>void glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameteriv;

        /// <summary>void glGetIntegerv(GLenum pname, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;

        /// <summary>void glGetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLchar*, void> glGetProgramInfoLog;

        /// <summary>void glGetProgramiv(GLuint program, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramPropertyARB, GLint*, void> glGetProgramiv;

        /// <summary>void glGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameteriv;

        /// <summary>void glGetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLsizei*, GLchar*, void> glGetShaderInfoLog;

        /// <summary>void glGetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, PrecisionType, GLint*, GLint*, void> glGetShaderPrecisionFormat;

        /// <summary>void glGetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLsizei*, GLchar*, void> glGetShaderSource;

        /// <summary>void glGetShaderiv(GLuint shader, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, ShaderParameterName, GLint*, void> glGetShaderiv;

        /// <summary>GLubyte* glGetString(GLenum name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;

        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;

        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;

        /// <summary>GLint glGetUniformLocation(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetUniformLocation;

        /// <summary>void glGetUniformfv(GLuint program, GLint location, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat*, void> glGetUniformfv;

        /// <summary>void glGetUniformiv(GLuint program, GLint location, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint*, void> glGetUniformiv;

        /// <summary>void glGetVertexAttribPointerv(GLuint index, GLenum pname, void** pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointerv;

        /// <summary>void glGetVertexAttribfv(GLuint index, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfv;

        /// <summary>void glGetVertexAttribiv(GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribiv;

        /// <summary>void glHint(GLenum target, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;

        /// <summary>GLboolean glIsBuffer(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsBuffer;

        /// <summary>GLboolean glIsEnabled(GLenum cap)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;

        /// <summary>GLboolean glIsFramebuffer(GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLboolean> glIsFramebuffer;

        /// <summary>GLboolean glIsProgram(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLboolean> glIsProgram;

        /// <summary>GLboolean glIsRenderbuffer(GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLboolean> glIsRenderbuffer;

        /// <summary>GLboolean glIsShader(GLuint shader)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLboolean> glIsShader;

        /// <summary>GLboolean glIsTexture(GLuint texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLboolean> glIsTexture;

        /// <summary>void glLineWidth(GLfloat width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;

        /// <summary>void glLinkProgram(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glLinkProgram;

        /// <summary>void glPixelStorei(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;

        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;

        /// <summary>void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glReadPixels;

        /// <summary>void glReleaseShaderCompiler()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glReleaseShaderCompiler;

        /// <summary>void glRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorage;

        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;

        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;

        /// <summary>void glShaderBinary(GLsizei count, const GLuint* shaders, GLenum binaryFormat, const void* binary, GLsizei length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLshader*, ShaderBinaryFormat, void*, GLsizei, void> glShaderBinary;

        /// <summary>void glShaderSource(GLuint shader, GLsizei count, const GLchar*const* string, const GLint* length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLchar**, GLint*, void> glShaderSource;

        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;

        /// <summary>void glStencilFuncSeparate(GLenum face, GLenum func, GLint ref, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilFunction, GLint, GLuint, void> glStencilFuncSeparate;

        /// <summary>void glStencilMask(GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;

        /// <summary>void glStencilMaskSeparate(GLenum face, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilMaskSeparate;

        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;

        /// <summary>void glStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparate;

        /// <summary>void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage2D;

        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;

        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;

        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;

        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;

        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const void* pixels)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;

        /// <summary>void glUniform1f(GLint location, GLfloat v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1f;

        /// <summary>void glUniform1fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fv;

        /// <summary>void glUniform1i(GLint location, GLint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1i;

        /// <summary>void glUniform1iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1iv;

        /// <summary>void glUniform2f(GLint location, GLfloat v0, GLfloat v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2f;

        /// <summary>void glUniform2fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fv;

        /// <summary>void glUniform2i(GLint location, GLint v0, GLint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2i;

        /// <summary>void glUniform2iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2iv;

        /// <summary>void glUniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3f;

        /// <summary>void glUniform3fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fv;

        /// <summary>void glUniform3i(GLint location, GLint v0, GLint v1, GLint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3i;

        /// <summary>void glUniform3iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3iv;

        /// <summary>void glUniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4f;

        /// <summary>void glUniform4fv(GLint location, GLsizei count, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fv;

        /// <summary>void glUniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4i;

        /// <summary>void glUniform4iv(GLint location, GLsizei count, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4iv;

        /// <summary>void glUniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fv;

        /// <summary>void glUniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fv;

        /// <summary>void glUniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fv;

        /// <summary>void glUseProgram(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glUseProgram;

        /// <summary>void glValidateProgram(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glValidateProgram;

        /// <summary>void glVertexAttrib1f(GLuint index, GLfloat x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1f;

        /// <summary>void glVertexAttrib1fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fv;

        /// <summary>void glVertexAttrib2f(GLuint index, GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2f;

        /// <summary>void glVertexAttrib2fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fv;

        /// <summary>void glVertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3f;

        /// <summary>void glVertexAttrib3fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fv;

        /// <summary>void glVertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4f;

        /// <summary>void glVertexAttrib4fv(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fv;

        /// <summary>void glVertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointer;

        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;
    }
}
#endif