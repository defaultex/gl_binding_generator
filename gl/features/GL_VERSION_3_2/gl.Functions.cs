public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncObjectMask, GLuint64, SyncStatus> glClientWaitSync;
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, void> glDeleteSync;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLint, void> glDrawElementsBaseVertex;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, void> glDrawElementsInstancedBaseVertex;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, GLint, void> glDrawRangeElementsBaseVertex;
        public static unsafe delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, GLsync> glFenceSync;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, void> glFramebufferTexture;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPNameARB, GLint64*, void> glGetBufferParameteri64v;
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint64*, void> glGetInteger64i_v;
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLint64*, void> glGetInteger64v;
        public static unsafe delegate* unmanaged[Cdecl]<GetMultisamplePNameNV, GLuint, GLfloat*, void> glGetMultisamplefv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncParameterName, GLsizei, GLsizei*, GLint*, void> glGetSynciv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, GLboolean> glIsSync;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, GLint*, void> glMultiDrawElementsBaseVertex;
        public static unsafe delegate* unmanaged[Cdecl]<VertexProvokingMode, void> glProvokingVertex;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glSampleMaski;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLboolean, void> glTexImage2DMultisample;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, InternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, void> glTexImage3DMultisample;
        public static unsafe delegate* unmanaged[Cdecl]<GLsync, SyncBehaviorFlags, GLuint64, void> glWaitSync;
    }
}
