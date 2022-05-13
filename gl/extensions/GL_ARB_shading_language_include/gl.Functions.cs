#if GL_ARB_shading_language_include

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLchar**, GLint*, void> glCompileShaderIncludeARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, void> glDeleteNamedStringARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLsizei, GLint*, GLchar*, void> glGetNamedStringARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLenum, GLint*, void> glGetNamedStringivARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLchar*, GLboolean> glIsNamedStringARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, GLchar*, GLint, GLchar*, void> glNamedStringARB;
    }
}

#endif