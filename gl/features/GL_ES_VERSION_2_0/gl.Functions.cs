#if (GL_ES_VERSION_2_0 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glActiveTexture(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glAttachShader(GLuint program, GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, shader, void> glAttachShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindAttribLocation(GLuint program, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLchar*, void> glBindAttribLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindBuffer(GLenum target, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, buffer, void> glBindBuffer;
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
        /// <summary>void glBindTexture(GLenum target, GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, texture, void> glBindTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquation(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendFunc(GLenum sfactor, GLenum dfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, void> glBlendFunc;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBufferData(GLenum target, GLsizeiptr size, void* data, GLenum usage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, void*, BufferUsageARB, void> glBufferData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void*, void> glBufferSubData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLenum glCheckFramebufferStatus(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferStatus> glCheckFramebufferStatus;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClear(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClearBufferMask, void> glClear;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glClearColor;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearDepthf(GLfloat d);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearStencil(GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glClearStencil;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMask;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompileShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, void> glCompileShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glCreateProgram();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program> glCreateProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glCreateShader(GLenum type);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, shader> glCreateShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCullFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CullFaceMode, void> glCullFace;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, buffer*, void> glDeleteBuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteFramebuffers(GLsizei n, GLuint* framebuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, framebuffer*, void> glDeleteFramebuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glDeleteProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteRenderbuffers(GLsizei n, GLuint* renderbuffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, renderbuffer*, void> glDeleteRenderbuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, void> glDeleteShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, void> glDeleteTextures;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthFunc(GLenum func);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DepthFunction, void> glDepthFunc;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthMask(GLboolean flag);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, void> glDepthMask;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDepthRangef(GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDetachShader(GLuint program, GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, shader, void> glDetachShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDisable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glDisable;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDisableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArray;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawArrays(GLenum mode, GLint first, GLsizei count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElements(GLenum mode, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, void> glDrawElements;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnable(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, void> glEnable;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArray;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFinish();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFinish;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFlush();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlush;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, renderbuffer, void> glFramebufferRenderbuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, texture, GLint, void> glFramebufferTexture2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFrontFace(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FrontFaceDirection, void> glFrontFace;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenBuffers(GLsizei n, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, buffer*, void> glGenBuffers;
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
        /// <summary>void glGenTextures(GLsizei n, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, void> glGenTextures;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLint*, AttributeType*, GLchar*, void> glGetActiveAttrib;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLint*, UniformType*, GLchar*, void> glGetActiveUniform;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, shader*, void> glGetAttachedShaders;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetAttribLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetAttribLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBooleanv(GLenum pname, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLboolean*, void> glGetBooleanv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetBufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint*, void> glGetBufferParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLenum glGetError();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ErrorCode> glGetError;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetFloatv(GLenum pname, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfloat*, void> glGetFloatv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetIntegerv(GLenum pname, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint*, void> glGetIntegerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, GLchar*, void> glGetProgramInfoLog;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramiv(GLuint program, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramPropertyARB, GLint*, void> glGetProgramiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLsizei*, GLchar*, void> glGetShaderInfoLog;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderiv(GLuint shader, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, ShaderParameterName, GLint*, void> glGetShaderiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, PrecisionType, GLint*, GLint*, void> glGetShaderPrecisionFormat;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLsizei*, GLchar*, void> glGetShaderSource;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLubyte* glGetString(GLenum name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLubyte*> glGetString;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfloat*, void> glGetTexParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformfv(GLuint program, GLint location, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat*, void> glGetUniformfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformiv(GLuint program, GLint location, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint*, void> glGetUniformiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetUniformLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetUniformLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribfv(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribiv(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribPointerv(GLuint index, GLenum pname, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glHint(GLenum target, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HintTarget, HintMode, void> glHint;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsBuffer(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLboolean> glIsBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsEnabled(GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLboolean> glIsEnabled;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsFramebuffer(GLuint framebuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLboolean> glIsFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLboolean> glIsProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsRenderbuffer(GLuint renderbuffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<renderbuffer, GLboolean> glIsRenderbuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLboolean> glIsShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsTexture(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLboolean> glIsTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLineWidth(GLfloat width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glLineWidth;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLinkProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glLinkProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPixelStorei(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLint, void> glPixelStorei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPolygonOffset(GLfloat factor, GLfloat units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glReadPixels;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glReleaseShaderCompiler();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glReleaseShaderCompiler;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glScissor(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glScissor;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glShaderBinary(GLsizei count, GLuint* shaders, GLenum binaryFormat, void* binary, GLsizei length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, shader*, ShaderBinaryFormat, void*, GLsizei, void> glShaderBinary;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glShaderSource(GLuint shader, GLsizei count, GLchar** string, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLchar**, GLint*, void> glShaderSource;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilFunc(GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFunction, GLint, GLuint, void> glStencilFunc;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilFuncSeparate(GLenum face, GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilFunction, GLint, GLuint, void> glStencilFuncSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilMask(GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glStencilMask;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilMaskSeparate(GLenum face, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilMaskSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilOp, StencilOp, StencilOp, void> glStencilOp;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameterf(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat, void> glTexParameterf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLfloat*, void> glTexParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint, void> glTexParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1f(GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1i(GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2f(GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2i(GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3i(GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUseProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glUseProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glValidateProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glValidateProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1f(GLuint index, GLfloat x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2f(GLuint index, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glViewport(GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, void> glViewport;
#endif
    }
}
#endif