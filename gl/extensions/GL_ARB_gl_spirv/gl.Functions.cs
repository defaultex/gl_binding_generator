#if GL_ARB_gl_spirv

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLchar*, GLuint, GLuint*, GLuint*, void> glSpecializeShaderARB;
    }
}

#endif