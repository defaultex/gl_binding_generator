#if (GL_SGIX_sprite && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSpriteParameterfSGIX(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLfloat, void> glSpriteParameterfSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSpriteParameterfvSGIX(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLfloat*, void> glSpriteParameterfvSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSpriteParameteriSGIX(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLint, void> glSpriteParameteriSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSpriteParameterivSGIX(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, GLint*, void> glSpriteParameterivSGIX;
#endif
    }
}
#endif