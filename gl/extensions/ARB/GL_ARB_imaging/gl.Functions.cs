#if (GL_ARB_imaging && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquation(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquation;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorSubTable(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glColorSubTable;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorTable(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* table);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, InternalFormat, GLsizei, PixelFormat, PixelType, void*, void> glColorTable;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorTableParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, ColorTableParameterPNameSGI, GLfloat*, void> glColorTableParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorTableParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, ColorTableParameterPNameSGI, GLint*, void> glColorTableParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionFilter1D(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, InternalFormat, GLsizei, PixelFormat, PixelType, void*, void> glConvolutionFilter1D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, InternalFormat, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glConvolutionFilter2D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameterf(GLenum target, GLenum pname, GLfloat params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, ConvolutionParameterEXT, GLfloat, void> glConvolutionParameterf;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, ConvolutionParameterEXT, GLfloat*, void> glConvolutionParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameteri(GLenum target, GLenum pname, GLint params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, ConvolutionParameterEXT, GLint, void> glConvolutionParameteri;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, ConvolutionParameterEXT, GLint*, void> glConvolutionParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyColorSubTable(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GLsizei, GLint, GLint, GLsizei, void> glCopyColorSubTable;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyColorTable(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, InternalFormat, GLint, GLint, GLsizei, void> glCopyColorTable;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyConvolutionFilter1D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, InternalFormat, GLint, GLint, GLsizei, void> glCopyConvolutionFilter1D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyConvolutionFilter2D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, InternalFormat, GLint, GLint, GLsizei, GLsizei, void> glCopyConvolutionFilter2D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTable(GLenum target, GLenum format, GLenum type, void* table);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, PixelFormat, PixelType, void*, void> glGetColorTable;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GetColorTableParameterPNameSGI, GLfloat*, void> glGetColorTableParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GetColorTableParameterPNameSGI, GLint*, void> glGetColorTableParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetConvolutionFilter(GLenum target, GLenum format, GLenum type, void* image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, PixelFormat, PixelType, void*, void> glGetConvolutionFilter;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetConvolutionParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, ConvolutionParameterEXT, GLfloat*, void> glGetConvolutionParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetConvolutionParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTarget, ConvolutionParameterEXT, GLint*, void> glGetConvolutionParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetHistogram(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLboolean, PixelFormat, PixelType, void*, void> glGetHistogram;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetHistogramParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLfloat*, void> glGetHistogramParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetHistogramParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLint*, void> glGetHistogramParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMinmax(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GLboolean, PixelFormat, PixelType, void*, void> glGetMinmax;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMinmaxParameterfv(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GetMinmaxParameterPNameEXT, GLfloat*, void> glGetMinmaxParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMinmaxParameteriv(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GetMinmaxParameterPNameEXT, GLint*, void> glGetMinmaxParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSeparableFilter(GLenum target, GLenum format, GLenum type, void* row, void* column, void* span);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, PixelFormat, PixelType, void*, void*, void*, void> glGetSeparableFilter;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glHistogram(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLsizei, InternalFormat, GLboolean, void> glHistogram;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMinmax(GLenum target, GLenum internalformat, GLboolean sink);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, InternalFormat, GLboolean, void> glMinmax;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResetHistogram(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, void> glResetHistogram;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResetMinmax(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, void> glResetMinmax;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSeparableFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* row, void* column);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, InternalFormat, GLsizei, GLsizei, PixelFormat, PixelType, void*, void*, void> glSeparableFilter2D;
#endif
    }
}
#endif