#if (GL_ES_VERSION_3_2 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBlendBarrier()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrier;

        /// <summary>void glBlendEquationSeparatei(GLuint buf, GLenum modeRGB, GLenum modeAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparatei;

        /// <summary>void glBlendEquationi(GLuint buf, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationi;

        /// <summary>void glBlendFuncSeparatei(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparatei;

        /// <summary>void glBlendFunci(GLuint buf, GLenum src, GLenum dst)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunci;

        /// <summary>void glColorMaski(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaski;

        /// <summary>void glCopyImageSubData(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glCopyImageSubData;

        /// <summary>void glDebugMessageCallback(GLDEBUGPROC callback, const void* userParam)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROC, void*, void> glDebugMessageCallback;

        /// <summary>void glDebugMessageControl(GLenum source, GLenum type, GLenum severity, GLsizei count, const GLuint* ids, GLboolean enabled)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControl;

        /// <summary>void glDebugMessageInsert(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar* buf)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsert;

        /// <summary>void glDisablei(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisablei;

        /// <summary>void glDrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, const void* indices, GLint basevertex)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertex;

        /// <summary>void glDrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, const void* indices, GLsizei instancecount, GLint basevertex)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertex;

        /// <summary>void glDrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const void* indices, GLint basevertex)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertex;

        /// <summary>void glEnablei(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnablei;

        /// <summary>void glFramebufferTexture(GLenum target, GLenum attachment, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, void> glFramebufferTexture;

        /// <summary>GLuint glGetDebugMessageLog(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLog;

        /// <summary>GLenum glGetGraphicsResetStatus()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetGraphicsResetStatus;

        /// <summary>void glGetObjectLabel(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabel;

        /// <summary>void glGetObjectPtrLabel(const void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabel;

        /// <summary>void glGetPointerv(GLenum pname, void** params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;

        /// <summary>void glGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIiv;

        /// <summary>void glGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuiv;

        /// <summary>void glGetTexParameterIiv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIiv;

        /// <summary>void glGetTexParameterIuiv(GLenum target, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuiv;

        /// <summary>void glGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfv;

        /// <summary>void glGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformiv;

        /// <summary>void glGetnUniformuiv(GLuint program, GLint location, GLsizei bufSize, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glGetnUniformuiv;

        /// <summary>GLboolean glIsEnabledi(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledi;

        /// <summary>void glMinSampleShading(GLfloat value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShading;

        /// <summary>void glObjectLabel(GLenum identifier, GLuint name, GLsizei length, const GLchar* label)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabel;

        /// <summary>void glObjectPtrLabel(const void* ptr, GLsizei length, const GLchar* label)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabel;

        /// <summary>void glPatchParameteri(GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteri;

        /// <summary>void glPopDebugGroup()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroup;

        /// <summary>void glPrimitiveBoundingBox(GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glPrimitiveBoundingBox;

        /// <summary>void glPushDebugGroup(GLenum source, GLuint id, GLsizei length, const GLchar* message)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroup;

        /// <summary>void glReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixels;

        /// <summary>void glSamplerParameterIiv(GLuint sampler, GLenum pname, const GLint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameterIiv;

        /// <summary>void glSamplerParameterIuiv(GLuint sampler, GLenum pname, const GLuint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuiv;

        /// <summary>void glTexBuffer(GLenum target, GLenum internalformat, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, void> glTexBuffer;

        /// <summary>void glTexBufferRange(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, GLintptr, GLsizeiptr, void> glTexBufferRange;

        /// <summary>void glTexParameterIiv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIiv;

        /// <summary>void glTexParameterIuiv(GLenum target, GLenum pname, const GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuiv;

        /// <summary>void glTexStorage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexStorage3DMultisample;
    }
}
#endif