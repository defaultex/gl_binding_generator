#if (GL_EXT_convolution && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLsizei, PixelFormat, PixelType, void*, void> glConvolutionFilter1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glConvolutionFilter2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameterfEXT(GLenum target, GLenum pname, GLfloat params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfloat, void> glConvolutionParameterfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameterfvEXT(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfloat*, void> glConvolutionParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameteriEXT(GLenum target, GLenum pname, GLint params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLint, void> glConvolutionParameteriEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLint*, void> glConvolutionParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLint, GLint, GLsizei, void> glCopyConvolutionFilter1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, InternalFormat, GLint, GLint, GLsizei, GLsizei, void> glCopyConvolutionFilter2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetConvolutionFilterEXT(GLenum target, GLenum format, GLenum type, void* image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, PixelFormat, PixelType, void*, void> glGetConvolutionFilterEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetConvolutionParameterfvEXT(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfloat*, void> glGetConvolutionParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetConvolutionParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLint*, void> glGetConvolutionParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSeparableFilterEXT(GLenum target, GLenum format, GLenum type, void* row, void* column, void* span);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, PixelFormat, PixelType, void*, void*, void*, void> glGetSeparableFilterEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSeparableFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* row, void* column);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SeparableTargetEXT, InternalFormat, GLsizei, GLsizei, PixelFormat, PixelType, void*, void*, void> glSeparableFilter2DEXT;
#endif
    }
}
#endif