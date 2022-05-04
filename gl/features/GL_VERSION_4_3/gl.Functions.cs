#if (GL_VERSION_4_3 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindVertexBuffer(GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, buffer, GLintptr, GLsizei, void> glBindVertexBuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearBufferData(GLenum target, GLenum internalformat, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearBufferData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearBufferSubData(GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, SizedInternalFormat, GLintptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearBufferSubData;
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
        /// <summary>void glDispatchCompute(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glDispatchCompute;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDispatchComputeIndirect(GLintptr indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDispatchComputeIndirect;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glFramebufferParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, GLint, void> glFramebufferParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetDebugMessageLog(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLog;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetFramebufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetInternalformati64v(GLenum target, GLenum internalformat, GLenum pname, GLsizei count, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint64*, void> glGetInternalformati64v;
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
        /// <summary>void glGetProgramInterfaceiv(GLuint program, GLenum programInterface, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, ProgramInterfacePName, GLint*, void> glGetProgramInterfaceiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetProgramResourceIndex(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLchar*, GLuint> glGetProgramResourceIndex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramResourceiv(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei count, GLsizei* length, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLuint, GLsizei, ProgramResourceProperty*, GLsizei, GLsizei*, GLint*, void> glGetProgramResourceiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetProgramResourceLocation(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetProgramResourceLocationIndex(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocationIndex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramResourceName(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramInterface, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetProgramResourceName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateBufferData(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, void> glInvalidateBufferData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLintptr, GLsizeiptr, void> glInvalidateBufferSubData;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glInvalidateFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateSubFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateSubFramebuffer;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateTexImage(GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, void> glInvalidateTexImage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glInvalidateTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glInvalidateTexSubImage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiDrawArraysIndirect(GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirect;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiDrawElementsIndirect(GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirect;
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
        /// <summary>void glPopDebugGroup();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroup;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPushDebugGroup(GLenum source, GLuint id, GLsizei length, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroup;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glShaderStorageBlockBinding(GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLuint, void> glShaderStorageBlockBinding;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexBufferRange(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, buffer, GLintptr, GLsizeiptr, void> glTexBufferRange;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTexStorage2DMultisample;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexStorage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexStorage3DMultisample;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTextureView(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, TextureTarget, texture, SizedInternalFormat, GLuint, GLuint, GLuint, GLuint, void> glTextureView;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribBinding(GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribBinding;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribFormat(GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribFormat;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribIFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLuint, void> glVertexAttribIFormat;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribLFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLuint, void> glVertexAttribLFormat;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexBindingDivisor(GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexBindingDivisor;
#endif
    }
}
#endif