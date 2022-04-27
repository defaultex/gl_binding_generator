#if (GL_OES_get_program_binary && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glGetProgramBinaryOES(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinaryOES;

        /// <summary>void glProgramBinaryOES(GLuint program, GLenum binaryFormat, const void* binary, GLint length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLenum, void*, GLint, void> glProgramBinaryOES;
    }
}
#endif