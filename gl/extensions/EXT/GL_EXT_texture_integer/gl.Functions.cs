#if (GL_EXT_texture_integer && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glClearColorIiEXT;

        /// <summary>void glClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glClearColorIuiEXT;

        /// <summary>void glGetTexParameterIivEXT(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLint*, void> glGetTexParameterIivEXT;

        /// <summary>void glGetTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLuint*, void> glGetTexParameterIuivEXT;

        /// <summary>void glTexParameterIivEXT(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLint*, void> glTexParameterIivEXT;

        /// <summary>void glTexParameterIuivEXT(GLenum target, GLenum pname, const GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, GLuint*, void> glTexParameterIuivEXT;
    }
}
#endif