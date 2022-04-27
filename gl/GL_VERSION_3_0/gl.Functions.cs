#if (GL_VERSION_3_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginConditionalRender(GLuint id, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ConditionalRenderMode, void> glBeginConditionalRender;

#if !GL_ES_VERSION_3_0

        /// <summary>void glBeginTransformFeedback(GLenum primitiveMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedback;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glBindBufferBase(GLenum target, GLuint index, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, void> glBindBufferBase;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glBindBufferRange;

#endif

        /// <summary>void glBindFragDataLocation(GLuint program, GLuint color, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLchar*, void> glBindFragDataLocation;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glBindFramebuffer(GLenum target, GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLframebuffer, void> glBindFramebuffer;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glBindRenderbuffer(GLenum target, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLrenderbuffer, void> glBindRenderbuffer;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glBindVertexArray(GLuint array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, void> glBindVertexArray;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, BlitFramebufferFilter, void> glBlitFramebuffer;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>GLenum glCheckFramebufferStatus(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLenum> glCheckFramebufferStatus;

#endif

        /// <summary>void glClampColor(GLenum target, GLenum clamp)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClampColorTargetARB, ClampColorModeARB, void> glClampColor;

#if !GL_ES_VERSION_3_0

        /// <summary>void glClearBufferfi(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat, GLint, void> glClearBufferfi;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glClearBufferfv(GLenum buffer, GLint drawbuffer, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLfloat*, void> glClearBufferfv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glClearBufferiv(GLenum buffer, GLint drawbuffer, const GLint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLint*, void> glClearBufferiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glClearBufferuiv(GLenum buffer, GLint drawbuffer, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<Buffer, GLint, GLuint*, void> glClearBufferuiv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glColorMaski(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaski;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDeleteFramebuffers(GLsizei n, const GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glDeleteFramebuffers;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>void glDeleteRenderbuffers(GLsizei n, const GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glDeleteRenderbuffers;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glDeleteVertexArrays(GLsizei n, const GLuint* arrays)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glDeleteVertexArrays;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glDisablei(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisablei;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glEnablei(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnablei;

#endif

        /// <summary>void glEndConditionalRender()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRender;

#if !GL_ES_VERSION_3_0

        /// <summary>void glEndTransformFeedback()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedback;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glFlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, void> glFlushMappedBufferRange;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, GLrenderbuffer, void> glFramebufferRenderbuffer;

#endif

        /// <summary>void glFramebufferTexture1D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture1D;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, void> glFramebufferTexture2D;

#endif

        /// <summary>void glFramebufferTexture3D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, GLtexture, GLint, GLint, void> glFramebufferTexture3D;

#if !GL_ES_VERSION_3_0

        /// <summary>void glFramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, void> glFramebufferTextureLayer;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGenFramebuffers(GLsizei n, GLuint* framebuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLframebuffer*, void> glGenFramebuffers;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGenRenderbuffers(GLsizei n, GLuint* renderbuffers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLrenderbuffer*, void> glGenRenderbuffers;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGenVertexArrays(GLsizei n, GLuint* arrays)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLvertexarray*, void> glGenVertexArrays;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGenerateMipmap(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, void> glGenerateMipmap;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glGetBooleani_v(GLenum target, GLuint index, GLboolean* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLboolean*, void> glGetBooleani_v;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>GLint glGetFragDataLocation(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataLocation;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferAttachmentParameteriv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, RenderbufferParameterName, GLint*, void> glGetRenderbufferParameteriv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>GLubyte* glGetStringi(GLenum name, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StringName, GLuint, GLubyte*> glGetStringi;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glGetTexParameterIiv(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIiv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glGetTexParameterIuiv(GLenum target, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLsizei*, AttributeType*, GLchar*, void> glGetTransformFeedbackVarying;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetUniformuiv(GLuint program, GLint location, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint*, void> glGetUniformuiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetVertexAttribIiv(GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint*, void> glGetVertexAttribIiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetVertexAttribIuiv(GLuint index, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint*, void> glGetVertexAttribIuiv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>GLboolean glIsEnabledi(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnabledi;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLboolean glIsFramebuffer(GLuint framebuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLboolean> glIsFramebuffer;

#endif

#if !GL_ES_VERSION_2_0

        /// <summary>GLboolean glIsRenderbuffer(GLuint renderbuffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLrenderbuffer, GLboolean> glIsRenderbuffer;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>GLboolean glIsVertexArray(GLuint array)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLvertexarray, GLboolean> glIsVertexArray;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void* glMapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLintptr, GLsizeiptr, MapBufferAccessMask, void*> glMapBufferRange;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorage;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glRenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisample;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glTexParameterIiv(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIiv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glTexParameterIuiv(GLenum target, GLenum pname, const GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glTransformFeedbackVaryings(GLuint program, GLsizei count, const GLchar*const* varyings, GLenum bufferMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, TransformFeedbackBufferMode, void> glTransformFeedbackVaryings;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform1ui(GLint location, GLuint v0)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, void> glUniform1ui;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform1uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform1uiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform2ui(GLint location, GLuint v0, GLuint v1)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, void> glUniform2ui;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform2uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform2uiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform3ui(GLint location, GLuint v0, GLuint v1, GLuint v2)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, void> glUniform3ui;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform3uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform3uiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform4ui(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, GLuint, void> glUniform4ui;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniform4uiv(GLint location, GLsizei count, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform4uiv;

#endif

        /// <summary>void glVertexAttribI1i(GLuint index, GLint x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, void> glVertexAttribI1i;

        /// <summary>void glVertexAttribI1iv(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI1iv;

        /// <summary>void glVertexAttribI1ui(GLuint index, GLuint x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribI1ui;

        /// <summary>void glVertexAttribI1uiv(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI1uiv;

        /// <summary>void glVertexAttribI2i(GLuint index, GLint x, GLint y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, void> glVertexAttribI2i;

        /// <summary>void glVertexAttribI2iv(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI2iv;

        /// <summary>void glVertexAttribI2ui(GLuint index, GLuint x, GLuint y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glVertexAttribI2ui;

        /// <summary>void glVertexAttribI2uiv(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI2uiv;

        /// <summary>void glVertexAttribI3i(GLuint index, GLint x, GLint y, GLint z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, void> glVertexAttribI3i;

        /// <summary>void glVertexAttribI3iv(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI3iv;

        /// <summary>void glVertexAttribI3ui(GLuint index, GLuint x, GLuint y, GLuint z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI3ui;

        /// <summary>void glVertexAttribI3uiv(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI3uiv;

        /// <summary>void glVertexAttribI4bv(GLuint index, const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttribI4bv;

#if !GL_ES_VERSION_3_0

        /// <summary>void glVertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, GLint, void> glVertexAttribI4i;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glVertexAttribI4iv(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI4iv;

#endif

        /// <summary>void glVertexAttribI4sv(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttribI4sv;

        /// <summary>void glVertexAttribI4ubv(GLuint index, const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttribI4ubv;

#if !GL_ES_VERSION_3_0

        /// <summary>void glVertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI4ui;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glVertexAttribI4uiv(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI4uiv;

#endif

        /// <summary>void glVertexAttribI4usv(GLuint index, const GLushort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttribI4usv;

#if !GL_ES_VERSION_3_0

        /// <summary>void glVertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void*, void> glVertexAttribIPointer;

#endif
    }
}
#endif