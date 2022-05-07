#if (GL_ARB_get_program_binary && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetProgramBinary(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLenum*, void*, void> glGetProgramBinary;

        /// <summary>void glProgramBinary(GLuint program, GLenum binaryFormat, void* binary, GLsizei length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLenum, void*, GLsizei, void> glProgramBinary;

        /// <summary>void glProgramParameteri(GLuint program, GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramParameterPName, GLint, void> glProgramParameteri;
    }
}
#endif