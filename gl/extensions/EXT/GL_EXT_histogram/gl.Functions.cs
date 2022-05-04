#if (GL_EXT_histogram && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetHistogramEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLboolean, PixelFormat, PixelType, void*, void> glGetHistogramEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetHistogramParameterfvEXT(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLfloat*, void> glGetHistogramParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetHistogramParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLint*, void> glGetHistogramParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMinmaxEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GLboolean, PixelFormat, PixelType, void*, void> glGetMinmaxEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMinmaxParameterfvEXT(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GetMinmaxParameterPNameEXT, GLfloat*, void> glGetMinmaxParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMinmaxParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, GetMinmaxParameterPNameEXT, GLint*, void> glGetMinmaxParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glHistogramEXT(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GLsizei, InternalFormat, GLboolean, void> glHistogramEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMinmaxEXT(GLenum target, GLenum internalformat, GLboolean sink);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, InternalFormat, GLboolean, void> glMinmaxEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResetHistogramEXT(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, void> glResetHistogramEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResetMinmaxEXT(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MinmaxTargetEXT, void> glResetMinmaxEXT;
#endif
    }
}
#endif