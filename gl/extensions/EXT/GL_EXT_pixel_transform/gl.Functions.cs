#if (GL_EXT_pixel_transform && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetPixelTransformParameterfvEXT(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLfloat*, void> glGetPixelTransformParameterfvEXT;

        /// <summary>void glGetPixelTransformParameterivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLint*, void> glGetPixelTransformParameterivEXT;

        /// <summary>void glPixelTransformParameterfEXT(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLfloat, void> glPixelTransformParameterfEXT;

        /// <summary>void glPixelTransformParameterfvEXT(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLfloat*, void> glPixelTransformParameterfvEXT;

        /// <summary>void glPixelTransformParameteriEXT(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLint, void> glPixelTransformParameteriEXT;

        /// <summary>void glPixelTransformParameterivEXT(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransformTargetEXT, PixelTransformPNameEXT, GLint*, void> glPixelTransformParameterivEXT;
    }
}
#endif