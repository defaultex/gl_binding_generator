#if (GL_VERSION_4_3 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindVertexBuffer(GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbuffer, GLintptr, GLsizei, void> glBindVertexBuffer;

        /// <summary>void glClearBufferData(GLenum target, GLenum internalformat, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearBufferData;

        /// <summary>void glClearBufferSubData(GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, SizedInternalFormat, GLintptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearBufferSubData;

        /// <summary>void glCopyImageSubData(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glCopyImageSubData;

        /// <summary>void glDebugMessageCallback(GLDEBUGPROC callback, void* userParam);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROC, void*, void> glDebugMessageCallback;

        /// <summary>void glDebugMessageControl(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControl;

        /// <summary>void glDebugMessageInsert(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsert;

        /// <summary>void glDispatchCompute(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glDispatchCompute;

        /// <summary>void glDispatchComputeIndirect(GLintptr indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDispatchComputeIndirect;

        /// <summary>void glFramebufferParameteri(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, GLint, void> glFramebufferParameteri;

        /// <summary>GLuint glGetDebugMessageLog(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLog;

        /// <summary>void glGetFramebufferParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferParameteriv;

        /// <summary>void glGetInternalformati64v(GLenum target, GLenum internalformat, GLenum pname, GLsizei count, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint64*, void> glGetInternalformati64v;

        /// <summary>void glGetObjectLabel(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabel;

        /// <summary>void glGetObjectPtrLabel(void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabel;

        /// <summary>void glGetPointerv(GLenum pname, void** params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;

        /// <summary>void glGetProgramInterfaceiv(GLuint program, GLenum programInterface, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, ProgramInterfacePName, GLint*, void> glGetProgramInterfaceiv;

        /// <summary>GLuint glGetProgramResourceIndex(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLuint> glGetProgramResourceIndex;

        /// <summary>void glGetProgramResourceiv(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei count, GLsizei* length, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, ProgramResourceProperty*, GLsizei, GLsizei*, GLint*, void> glGetProgramResourceiv;

        /// <summary>GLint glGetProgramResourceLocation(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocation;

        /// <summary>GLint glGetProgramResourceLocationIndex(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocationIndex;

        /// <summary>void glGetProgramResourceName(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetProgramResourceName;

        /// <summary>void glInvalidateBufferData(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void> glInvalidateBufferData;

        /// <summary>void glInvalidateBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void> glInvalidateBufferSubData;

        /// <summary>void glInvalidateFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glInvalidateFramebuffer;

        /// <summary>void glInvalidateSubFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateSubFramebuffer;

        /// <summary>void glInvalidateTexImage(GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, void> glInvalidateTexImage;

        /// <summary>void glInvalidateTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glInvalidateTexSubImage;

        /// <summary>void glMultiDrawArraysIndirect(GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirect;

        /// <summary>void glMultiDrawElementsIndirect(GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirect;

        /// <summary>void glObjectLabel(GLenum identifier, GLuint name, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabel;

        /// <summary>void glObjectPtrLabel(void* ptr, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabel;

        /// <summary>void glPopDebugGroup();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroup;

        /// <summary>void glPushDebugGroup(GLenum source, GLuint id, GLsizei length, GLchar* message);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroup;

        /// <summary>void glShaderStorageBlockBinding(GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, void> glShaderStorageBlockBinding;

        /// <summary>void glTexBufferRange(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, GLintptr, GLsizeiptr, void> glTexBufferRange;

        /// <summary>void glTexStorage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTexStorage2DMultisample;

        /// <summary>void glTexStorage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexStorage3DMultisample;

        /// <summary>void glTextureView(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLtexture, SizedInternalFormat, GLuint, GLuint, GLuint, GLuint, void> glTextureView;

        /// <summary>void glVertexAttribBinding(GLuint attribindex, GLuint bindingindex);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribBinding;

        /// <summary>void glVertexAttribFormat(GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribFormat;

        /// <summary>void glVertexAttribIFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLuint, void> glVertexAttribIFormat;

        /// <summary>void glVertexAttribLFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLuint, void> glVertexAttribLFormat;

        /// <summary>void glVertexBindingDivisor(GLuint bindingindex, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexBindingDivisor;
    }
}
#endif