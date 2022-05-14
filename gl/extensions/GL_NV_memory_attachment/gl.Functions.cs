#if GL_NV_memory_attachment

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLuint, GLuint64, void> glBufferAttachMemoryNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint, GLsizei, GLuint*, void> glGetMemoryObjectDetachedResourcesuivNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLuint, GLuint64, void> glNamedBufferAttachMemoryNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glResetMemoryObjectParameterNV;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLuint, GLuint64, void> glTexAttachMemoryNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint, GLuint64, void> glTextureAttachMemoryNV;
    }
}

#endif