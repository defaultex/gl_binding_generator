#if (GL_SGIX_sprite && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSpriteParameterfSGIX(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLfloat, void> glSpriteParameterfSGIX;

        /// <summary>void glSpriteParameterfvSGIX(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLfloat*, void> glSpriteParameterfvSGIX;

        /// <summary>void glSpriteParameteriSGIX(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLint, void> glSpriteParameteriSGIX;

        /// <summary>void glSpriteParameterivSGIX(GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLint*, void> glSpriteParameterivSGIX;
    }
}
#endif