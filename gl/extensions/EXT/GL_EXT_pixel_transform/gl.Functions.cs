#if (GL_EXT_pixel_transform && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPixelTransformParameterfvEXT(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLfloat*, void> glGetPixelTransformParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPixelTransformParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLint*, void> glGetPixelTransformParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTransformParameterfEXT(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLfloat, void> glPixelTransformParameterfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTransformParameterfvEXT(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLfloat*, void> glPixelTransformParameterfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTransformParameteriEXT(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLint, void> glPixelTransformParameteriEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTransformParameterivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLint*, void> glPixelTransformParameterivEXT;
#endif
    }
}
#endif