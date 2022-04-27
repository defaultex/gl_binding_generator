#if (GL_EXT_convolution && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const void* image)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLsizei, PixelFormat, PixelType, void*, void> glConvolutionFilter1DEXT;

        /// <summary>void glConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const void* image)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glConvolutionFilter2DEXT;

        /// <summary>void glConvolutionParameterfEXT(GLenum target, GLenum pname, GLfloat params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfloat, void> glConvolutionParameterfEXT;

        /// <summary>void glConvolutionParameterfvEXT(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfloat*, void> glConvolutionParameterfvEXT;

        /// <summary>void glConvolutionParameteriEXT(GLenum target, GLenum pname, GLint params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLint, void> glConvolutionParameteriEXT;

        /// <summary>void glConvolutionParameterivEXT(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLint*, void> glConvolutionParameterivEXT;

        /// <summary>void glCopyConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLint, GLint, GLsizei, void> glCopyConvolutionFilter1DEXT;

        /// <summary>void glCopyConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLint, GLint, GLsizei, GLsizei, void> glCopyConvolutionFilter2DEXT;

        /// <summary>void glGetConvolutionFilterEXT(GLenum target, GLenum format, GLenum type, void* image)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, PixelFormat, PixelType, void*, void> glGetConvolutionFilterEXT;

        /// <summary>void glGetConvolutionParameterfvEXT(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfloat*, void> glGetConvolutionParameterfvEXT;

        /// <summary>void glGetConvolutionParameterivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLint*, void> glGetConvolutionParameterivEXT;

        /// <summary>void glGetSeparableFilterEXT(GLenum target, GLenum format, GLenum type, void* row, void* column, void* span)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, PixelFormat, PixelType, void*, void*, void*, void> glGetSeparableFilterEXT;

        /// <summary>void glSeparableFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const void* row, const void* column)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, InternalFormat, GLsizei, GLsizei, PixelFormat, PixelType, void*, void*, void> glSeparableFilter2DEXT;
    }
}
#endif