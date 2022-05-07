#if (GL_QCOM_extended_get2 && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glExtGetProgramBinarySourceQCOM(GLuint program, GLenum shadertype, GLchar* source, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLchar*, GLint*, void> glExtGetProgramBinarySourceQCOM;

        /// <summary>void glExtGetProgramsQCOM(GLuint* programs, GLint maxPrograms, GLint* numPrograms);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram*, GLint, GLint*, void> glExtGetProgramsQCOM;

        /// <summary>void glExtGetShadersQCOM(GLuint* shaders, GLint maxShaders, GLint* numShaders);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader*, GLint, GLint*, void> glExtGetShadersQCOM;

        /// <summary>GLboolean glExtIsProgramBinaryQCOM(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLboolean> glExtIsProgramBinaryQCOM;
    }
}
#endif