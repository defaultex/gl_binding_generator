#if GL_ARB_shading_language_include

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glCompileShaderIncludeARB(GLuint shader, GLsizei count, GLchar** path, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLchar**, GLint*, void> glCompileShaderIncludeARB;

        /// <summary>void glDeleteNamedStringARB(GLint namelen, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, void> glDeleteNamedStringARB;

        /// <summary>void glGetNamedStringARB(GLint namelen, GLchar* name, GLsizei bufSize, GLint* stringlen, GLchar* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLsizei, GLint*, GLchar*, void> glGetNamedStringARB;

        /// <summary>void glGetNamedStringivARB(GLint namelen, GLchar* name, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLenum, GLint*, void> glGetNamedStringivARB;

        /// <summary>GLboolean glIsNamedStringARB(GLint namelen, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLboolean> glIsNamedStringARB;

        /// <summary>void glNamedStringARB(GLenum type, GLint namelen, GLchar* name, GLint stringlen, GLchar* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLchar*, GLint, GLchar*, void> glNamedStringARB;
    }
}

#endif