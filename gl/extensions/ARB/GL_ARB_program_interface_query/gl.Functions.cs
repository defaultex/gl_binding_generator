#if (GL_ARB_program_interface_query && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetProgramInterfaceiv(GLuint program, GLenum programInterface, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, ProgramInterfacePName, GLint*, void> glGetProgramInterfaceiv;

        /// <summary>GLuint glGetProgramResourceIndex(GLuint program, GLenum programInterface, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLuint> glGetProgramResourceIndex;

        /// <summary>GLint glGetProgramResourceLocation(GLuint program, GLenum programInterface, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocation;

        /// <summary>GLint glGetProgramResourceLocationIndex(GLuint program, GLenum programInterface, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocationIndex;

        /// <summary>void glGetProgramResourceName(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetProgramResourceName;

        /// <summary>void glGetProgramResourceiv(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, const GLenum* props, GLsizei count, GLsizei* length, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLuint, GLsizei, ProgramResourceProperty*, GLsizei, GLsizei*, GLint*, void> glGetProgramResourceiv;
    }
}
#endif