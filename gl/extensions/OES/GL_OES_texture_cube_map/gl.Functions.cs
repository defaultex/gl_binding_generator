#if (GL_OES_texture_cube_map && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glGetTexGenfvOES(GLenum coord, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glGetTexGenfvOES;

        /// <summary>void glGetTexGenivOES(GLenum coord, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glGetTexGenivOES;

        /// <summary>void glGetTexGenxvOES(GLenum coord, GLenum pname, GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glGetTexGenxvOES;

        /// <summary>void glTexGenfOES(GLenum coord, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat, void> glTexGenfOES;

        /// <summary>void glTexGenfvOES(GLenum coord, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfloat*, void> glTexGenfvOES;

        /// <summary>void glTexGeniOES(GLenum coord, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint, void> glTexGeniOES;

        /// <summary>void glTexGenivOES(GLenum coord, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLint*, void> glTexGenivOES;

        /// <summary>void glTexGenxOES(GLenum coord, GLenum pname, GLfixed param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed, void> glTexGenxOES;

        /// <summary>void glTexGenxvOES(GLenum coord, GLenum pname, const GLfixed* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glTexGenxvOES;
    }
}
#endif