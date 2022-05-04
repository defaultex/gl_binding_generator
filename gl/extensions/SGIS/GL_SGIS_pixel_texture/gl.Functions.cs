#if (GL_SGIS_pixel_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPixelTexGenParameterfvSGIS(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLfloat*, void> glGetPixelTexGenParameterfvSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPixelTexGenParameterivSGIS(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLint*, void> glGetPixelTexGenParameterivSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTexGenParameterfSGIS(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLfloat, void> glPixelTexGenParameterfSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTexGenParameterfvSGIS(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLfloat*, void> glPixelTexGenParameterfvSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTexGenParameteriSGIS(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLint, void> glPixelTexGenParameteriSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTexGenParameterivSGIS(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLint*, void> glPixelTexGenParameterivSGIS;
#endif
    }
}
#endif