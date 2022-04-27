#if (GL_EXT_histogram && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetHistogramEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLboolean, PixelFormat, PixelType, void*, void> glGetHistogramEXT;

        /// <summary>void glGetHistogramParameterfvEXT(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLfloat*, void> glGetHistogramParameterfvEXT;

        /// <summary>void glGetHistogramParameterivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLint*, void> glGetHistogramParameterivEXT;

        /// <summary>void glGetMinmaxEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GLboolean, PixelFormat, PixelType, void*, void> glGetMinmaxEXT;

        /// <summary>void glGetMinmaxParameterfvEXT(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GetMinmaxParameterPNameEXT, GLfloat*, void> glGetMinmaxParameterfvEXT;

        /// <summary>void glGetMinmaxParameterivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GetMinmaxParameterPNameEXT, GLint*, void> glGetMinmaxParameterivEXT;

        /// <summary>void glHistogramEXT(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLsizei, InternalFormat, GLboolean, void> glHistogramEXT;

        /// <summary>void glMinmaxEXT(GLenum target, GLenum internalformat, GLboolean sink)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, InternalFormat, GLboolean, void> glMinmaxEXT;

        /// <summary>void glResetHistogramEXT(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, void> glResetHistogramEXT;

        /// <summary>void glResetMinmaxEXT(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, void> glResetMinmaxEXT;
    }
}
#endif