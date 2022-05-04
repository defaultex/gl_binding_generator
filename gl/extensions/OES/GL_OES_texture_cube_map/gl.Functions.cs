#if (GL_OES_texture_cube_map && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexGenfvOES(GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glGetTexGenfvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexGenivOES(GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glGetTexGenivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexGenxvOES(GLenum coord, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glGetTexGenxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGenfOES(GLenum coord, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat, void> glTexGenfOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGenfvOES(GLenum coord, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glTexGenfvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGeniOES(GLenum coord, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint, void> glTexGeniOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGenivOES(GLenum coord, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glTexGenivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGenxOES(GLenum coord, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed, void> glTexGenxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGenxvOES(GLenum coord, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glTexGenxvOES;
#endif
    }
}
#endif