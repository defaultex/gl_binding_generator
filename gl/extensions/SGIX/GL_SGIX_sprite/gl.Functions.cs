#if (GL_SGIX_sprite && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSpriteParameterfSGIX(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLfloat, void> glSpriteParameterfSGIX;

        /// <summary>void glSpriteParameterfvSGIX(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLfloat*, void> glSpriteParameterfvSGIX;

        /// <summary>void glSpriteParameteriSGIX(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLint, void> glSpriteParameteriSGIX;

        /// <summary>void glSpriteParameterivSGIX(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLint*, void> glSpriteParameterivSGIX;
    }
}
#endif