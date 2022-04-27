#if (GL_EXT_blend_func_extended && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBindFragDataLocationEXT(GLuint program, GLuint color, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLchar*, void> glBindFragDataLocationEXT;

        /// <summary>void glBindFragDataLocationIndexedEXT(GLuint program, GLuint colorNumber, GLuint index, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexedEXT;

        /// <summary>GLint glGetFragDataIndexEXT(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataIndexEXT;

        /// <summary>GLint glGetProgramResourceLocationIndexEXT(GLuint program, GLenum programInterface, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocationIndexEXT;
    }
}
#endif