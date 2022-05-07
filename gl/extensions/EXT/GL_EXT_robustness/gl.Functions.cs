#if (GL_EXT_robustness && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>GLenum glGetGraphicsResetStatusEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatusEXT;

        /// <summary>void glGetnUniformfvEXT(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfvEXT;

        /// <summary>void glGetnUniformivEXT(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformivEXT;

        /// <summary>void glReadnPixelsEXT(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsEXT;
    }
}
#endif