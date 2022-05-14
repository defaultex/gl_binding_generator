#if GL_NV_shader_buffer_load

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLenum, GLuint64EXT*, void> glGetBufferParameterui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint64EXT*, void> glGetIntegerui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferParameter, GLuint64EXT*, void> glGetNamedBufferParameterui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT*, void> glGetUniformui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLboolean> glIsBufferResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsNamedBufferResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glMakeBufferNonResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, void> glMakeBufferResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void> glMakeNamedBufferNonResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLenum, void> glMakeNamedBufferResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, void> glProgramUniformui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniformui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, void> glUniformui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniformui64vNV;
    }
}

#endif