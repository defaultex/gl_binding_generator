#if GL_ARB_robustness

public partial class gl { 
    public partial class Functions { 

        /// <summary>GLenum glGetGraphicsResetStatusARB();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatusARB;

        /// <summary>void glGetnCompressedTexImageARB(GLenum target, GLint lod, GLsizei bufSize, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLsizei, void*, void> glGetnCompressedTexImageARB;

        /// <summary>void glGetnTexImageARB(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, PixelFormat, PixelType, GLsizei, void*, void> glGetnTexImageARB;

        /// <summary>void glGetnUniformdvARB(GLuint program, GLint location, GLsizei bufSize, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLdouble*, void> glGetnUniformdvARB;

        /// <summary>void glGetnUniformfvARB(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfvARB;

        /// <summary>void glGetnUniformivARB(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformivARB;

        /// <summary>void glGetnUniformuivARB(GLuint program, GLint location, GLsizei bufSize, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glGetnUniformuivARB;

        /// <summary>void glReadnPixelsARB(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsARB;
    }
}

#endif