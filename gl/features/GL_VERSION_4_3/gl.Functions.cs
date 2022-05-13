public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbuffer, GLintptr, GLsizei, void> glBindVertexBuffer;
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearBufferData;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, SizedInternalFormat, GLintptr, GLsizeiptr, PixelFormat, PixelType, void*, void> glClearBufferSubData;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLuint, CopyImageSubDataTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glCopyImageSubData;
        public static unsafe delegate* unmanaged[Cdecl]<GLDEBUGPROC, void*, void> glDebugMessageCallback;
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, GLsizei, GLuint*, GLboolean, void> glDebugMessageControl;
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, DebugType, GLuint, DebugSeverity, GLsizei, GLchar*, void> glDebugMessageInsert;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glDispatchCompute;
        public static unsafe delegate* unmanaged[Cdecl]<GLintptr, void> glDispatchComputeIndirect;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, GLint, void> glFramebufferParameteri;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, DebugSource*, DebugType*, GLuint*, DebugSeverity*, GLsizei*, GLchar*, GLuint> glGetDebugMessageLog;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLint*, void> glGetFramebufferParameteriv;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint64*, void> glGetInternalformati64v;
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabel;
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLsizei*, GLchar*, void> glGetObjectPtrLabel;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, ProgramInterfacePName, GLint*, void> glGetProgramInterfaceiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLuint> glGetProgramResourceIndex;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, ProgramResourceProperty*, GLsizei, GLsizei*, GLint*, void> glGetProgramResourceiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocation;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocationIndex;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetProgramResourceName;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void> glInvalidateBufferData;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLintptr, GLsizeiptr, void> glInvalidateBufferSubData;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, void> glInvalidateFramebuffer;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei, InvalidateFramebufferAttachment*, GLint, GLint, GLsizei, GLsizei, void> glInvalidateSubFramebuffer;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, void> glInvalidateTexImage;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glInvalidateTexSubImage;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, GLsizei, GLsizei, void> glMultiDrawArraysIndirect;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, GLsizei, GLsizei, void> glMultiDrawElementsIndirect;
        public static unsafe delegate* unmanaged[Cdecl]<ObjectIdentifier, GLuint, GLsizei, GLchar*, void> glObjectLabel;
        public static unsafe delegate* unmanaged[Cdecl]<void*, GLsizei, GLchar*, void> glObjectPtrLabel;
        public static unsafe delegate* unmanaged[Cdecl]<void> glPopDebugGroup;
        public static unsafe delegate* unmanaged[Cdecl]<DebugSource, GLuint, GLsizei, GLchar*, void> glPushDebugGroup;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, void> glShaderStorageBlockBinding;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, GLintptr, GLsizeiptr, void> glTexBufferRange;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, void> glTexStorage2DMultisample;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexStorage3DMultisample;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, TextureTarget, GLtexture, SizedInternalFormat, GLuint, GLuint, GLuint, GLuint, void> glTextureView;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribBinding;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribFormat;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLuint, void> glVertexAttribIFormat;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLuint, void> glVertexAttribLFormat;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexBindingDivisor;
    }
}
