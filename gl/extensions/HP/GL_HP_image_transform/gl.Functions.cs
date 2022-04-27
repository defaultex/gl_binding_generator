#if (GL_HP_image_transform && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetImageTransformParameterfvHP(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLfloat*, void> glGetImageTransformParameterfvHP;

        /// <summary>void glGetImageTransformParameterivHP(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLint*, void> glGetImageTransformParameterivHP;

        /// <summary>void glImageTransformParameterfHP(GLenum target, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLfloat, void> glImageTransformParameterfHP;

        /// <summary>void glImageTransformParameterfvHP(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLfloat*, void> glImageTransformParameterfvHP;

        /// <summary>void glImageTransformParameteriHP(GLenum target, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLint, void> glImageTransformParameteriHP;

        /// <summary>void glImageTransformParameterivHP(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLint*, void> glImageTransformParameterivHP;
    }
}
#endif