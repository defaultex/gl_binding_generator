#if (GL_ES_VERSION_3_2 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendBarrier();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrier;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquationi(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquationSeparatei(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparatei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendFunci(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunci;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendFuncSeparatei(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparatei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorMaski(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaski;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCopyImageSubData(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glCopyImageSubData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDebugMessageCallback(GLDEBUGPROC callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROC, void*, void> glDebugMessageCallback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDebugMessageControl(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControl;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDebugMessageInsert(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsert;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDisablei(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisablei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnablei(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnablei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferTexture(GLenum target, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, void> glFramebufferTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetDebugMessageLog(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLog;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLenum glGetGraphicsResetStatus();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatus;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glGetnUniformfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glGetnUniformiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetnUniformuiv(GLuint program, GLint location, GLsizei bufSize, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glGetnUniformuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetObjectLabel(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabel;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetObjectPtrLabel(void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabel;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuiv;
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
        /// <summary>GLboolean glIsEnabledi(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMinSampleShading(GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShading;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glObjectLabel(GLenum identifier, GLuint name, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabel;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glObjectPtrLabel(void* ptr, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabel;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPatchParameteri(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPopDebugGroup();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroup;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPrimitiveBoundingBox(GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glPrimitiveBoundingBox;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPushDebugGroup(GLenum source, GLuint id, GLsizei length, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroup;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixels;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameterIiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexBuffer(GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, buffer, void> glTexBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexBufferRange(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, buffer, GLintptr, GLsizeiptr, void> glTexBufferRange;
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
        /// <summary>void glTexStorage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexStorage3DMultisample;
#endif
    }
}
#endif