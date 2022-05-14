public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLuint, GLsizei, GLbuffer*, void> glBindBuffersBase;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLuint, GLsizei, GLbuffer*, GLintptr*, GLsizeiptr*, void> glBindBuffersRange;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLtexture*, void> glBindImageTextures;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsampler*, void> glBindSamplers;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLtexture*, void> glBindTextures;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLbuffer*, GLintptr*, GLsizei*, void> glBindVertexBuffers;
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLsizeiptr, void*, BufferStorageMask, void> glBufferStorage;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, PixelFormat, PixelType, void*, void> glClearTexImage;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glClearTexSubImage;
    }
}
