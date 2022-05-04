#if (GL_EXT_texture_integer && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glClearColorIiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glClearColorIuiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterIivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterIivEXT(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuivEXT;
#endif
    }
}
#endif