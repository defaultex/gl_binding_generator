#if (GL_SGI_color_table && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorTableParameterfvSGI(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTargetSGI, ColorTableParameterPNameSGI, GLfloat*, void> glColorTableParameterfvSGI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorTableParameterivSGI(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTargetSGI, ColorTableParameterPNameSGI, GLint*, void> glColorTableParameterivSGI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorTableSGI(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* table);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTargetSGI, InternalFormat, GLsizei, PixelFormat, PixelType, void*, void> glColorTableSGI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyColorTableSGI(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTargetSGI, InternalFormat, GLint, GLint, GLsizei, void> glCopyColorTableSGI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableParameterfvSGI(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTargetSGI, GetColorTableParameterPNameSGI, GLfloat*, void> glGetColorTableParameterfvSGI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableParameterivSGI(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTargetSGI, GetColorTableParameterPNameSGI, GLint*, void> glGetColorTableParameterivSGI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableSGI(GLenum target, GLenum format, GLenum type, void* table);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTargetSGI, PixelFormat, PixelType, void*, void> glGetColorTableSGI;
#endif
    }
}
#endif