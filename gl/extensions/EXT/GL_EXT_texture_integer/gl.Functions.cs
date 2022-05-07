#if (GL_EXT_texture_integer && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glClearColorIiEXT;

        /// <summary>void glClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glClearColorIuiEXT;
    }
}
#endif