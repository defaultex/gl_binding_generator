#if GL_ARB_robustness

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatusARB;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLsizei, void*, void> glGetnCompressedTexImageARB;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, GLsizei, void*, void> glGetnTexImageARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glGetnUniformdvARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfvARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformivARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glGetnUniformuivARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsARB;
    }
}

#endif