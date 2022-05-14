public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<BufferSubDataTarget, BufferSubDataTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubData;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstanced;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, ElementType, void*, GLsizei, void> glDrawElementsInstanced;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, UniformBlockParameter, GLint*, void> glGetActiveUniformBlockiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformBlockName;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformName;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLuint*, UniformParameter, GLint*, void> glGetActiveUniformsiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLuint> glGetUniformBlockIndex;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, GLuint*, void> glGetUniformIndices;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glPrimitiveRestartIndex;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, void> glTexBuffer;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, void> glUniformBlockBinding;
    }
}
