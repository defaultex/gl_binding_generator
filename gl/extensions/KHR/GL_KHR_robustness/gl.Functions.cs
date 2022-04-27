#if (GL_KHR_robustness && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLenum glGetGraphicsResetStatus()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetGraphicsResetStatus;

        /// <summary>GLenum glGetGraphicsResetStatusKHR()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum> glGetGraphicsResetStatusKHR;

        /// <summary>void glGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfv;

        /// <summary>void glGetnUniformfvKHR(GLuint program, GLint location, GLsizei bufSize, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLfloat*, void> glGetnUniformfvKHR;

        /// <summary>void glGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformiv;

        /// <summary>void glGetnUniformivKHR(GLuint program, GLint location, GLsizei bufSize, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLint*, void> glGetnUniformivKHR;

        /// <summary>void glGetnUniformuiv(GLuint program, GLint location, GLsizei bufSize, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glGetnUniformuiv;

        /// <summary>void glGetnUniformuivKHR(GLuint program, GLint location, GLsizei bufSize, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint*, void> glGetnUniformuivKHR;

        /// <summary>void glReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixels;

        /// <summary>void glReadnPixelsKHR(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsKHR;
    }
}
#endif