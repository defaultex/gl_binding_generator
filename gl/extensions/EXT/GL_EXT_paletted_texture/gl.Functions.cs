#if (GL_EXT_paletted_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorTableEXT(GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, void* table);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, InternalFormat, GLsizei, PixelFormat, PixelType, void*, void> glColorTableEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableEXT(GLenum target, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, PixelFormat, PixelType, void*, void> glGetColorTableEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableParameterfvEXT(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GetColorTableParameterPNameSGI, GLfloat*, void> glGetColorTableParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetColorTableParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorTableTarget, GetColorTableParameterPNameSGI, GLint*, void> glGetColorTableParameterivEXT;
#endif
    }
}
#endif