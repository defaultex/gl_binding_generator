#if (GL_EXT_blend_func_extended && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBindFragDataLocationEXT(GLuint program, GLuint color, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLchar*, void> glBindFragDataLocationEXT;

        /// <summary>void glBindFragDataLocationIndexedEXT(GLuint program, GLuint colorNumber, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexedEXT;

        /// <summary>GLint glGetFragDataIndexEXT(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataIndexEXT;

        /// <summary>GLint glGetProgramResourceLocationIndexEXT(GLuint program, GLenum programInterface, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramInterface, GLchar*, GLint> glGetProgramResourceLocationIndexEXT;
    }
}
#endif