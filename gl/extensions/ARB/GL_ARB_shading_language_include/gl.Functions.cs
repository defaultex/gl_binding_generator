#if (GL_ARB_shading_language_include && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCompileShaderIncludeARB(GLuint shader, GLsizei count, const GLchar*const* path, const GLint* length)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLchar**, GLint*, void> glCompileShaderIncludeARB;

        /// <summary>void glDeleteNamedStringARB(GLint namelen, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, void> glDeleteNamedStringARB;

        /// <summary>void glGetNamedStringARB(GLint namelen, const GLchar* name, GLsizei bufSize, GLint* stringlen, GLchar* string)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLsizei, GLint*, GLchar*, void> glGetNamedStringARB;

        /// <summary>void glGetNamedStringivARB(GLint namelen, const GLchar* name, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLenum, GLint*, void> glGetNamedStringivARB;

        /// <summary>GLboolean glIsNamedStringARB(GLint namelen, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLboolean> glIsNamedStringARB;

        /// <summary>void glNamedStringARB(GLenum type, GLint namelen, const GLchar* name, GLint stringlen, const GLchar* string)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLchar*, GLint, GLchar*, void> glNamedStringARB;
    }
}
#endif