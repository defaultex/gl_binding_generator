#if (GL_ARB_ES2_compatibility && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearDepthf(GLfloat d)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glClearDepthf;

        /// <summary>void glDepthRangef(GLfloat n, GLfloat f)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glDepthRangef;

        /// <summary>void glGetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, PrecisionType, GLint*, GLint*, void> glGetShaderPrecisionFormat;

        /// <summary>void glReleaseShaderCompiler()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glReleaseShaderCompiler;

        /// <summary>void glShaderBinary(GLsizei count, const GLuint* shaders, GLenum binaryFormat, const void* binary, GLsizei length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLshader*, ShaderBinaryFormat, void*, GLsizei, void> glShaderBinary;
    }
}
#endif