#if (GL_SGIS_pixel_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetPixelTexGenParameterfvSGIS(GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLfloat*, void> glGetPixelTexGenParameterfvSGIS;

        /// <summary>void glGetPixelTexGenParameterivSGIS(GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLint*, void> glGetPixelTexGenParameterivSGIS;

        /// <summary>void glPixelTexGenParameterfSGIS(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLfloat, void> glPixelTexGenParameterfSGIS;

        /// <summary>void glPixelTexGenParameterfvSGIS(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLfloat*, void> glPixelTexGenParameterfvSGIS;

        /// <summary>void glPixelTexGenParameteriSGIS(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLint, void> glPixelTexGenParameteriSGIS;

        /// <summary>void glPixelTexGenParameterivSGIS(GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, GLint*, void> glPixelTexGenParameterivSGIS;
    }
}
#endif