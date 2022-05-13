public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLtexture, GLint, GLboolean, GLint, BufferAccessARB, InternalFormat, void> glBindImageTexture;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, GLuint, void> glDrawArraysInstancedBaseInstance;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, PrimitiveType, void*, GLsizei, GLuint, void> glDrawElementsInstancedBaseInstance;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, GLint, GLuint, void> glDrawElementsInstancedBaseVertexBaseInstance;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLsizei, void> glDrawTransformFeedbackInstanced;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLuint, GLsizei, void> glDrawTransformFeedbackStreamInstanced;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, AtomicCounterBufferPName, GLint*, void> glGetActiveAtomicCounterBufferiv;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, InternalFormat, InternalFormatPName, GLsizei, GLint*, void> glGetInternalformativ;
        public static unsafe delegate* unmanaged[Cdecl]<MemoryBarrierMask, void> glMemoryBarrier;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, void> glTexStorage1D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, void> glTexStorage2D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, void> glTexStorage3D;
    }
}
