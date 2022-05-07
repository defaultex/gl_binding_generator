#if (GL_EXT_blend_color && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendColorEXT(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColorEXT;
    }
}
#endif