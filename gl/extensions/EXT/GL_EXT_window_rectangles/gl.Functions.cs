#if (GL_EXT_window_rectangles && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glWindowRectanglesEXT(GLenum mode, GLsizei count, GLint* box);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, GLint*, void> glWindowRectanglesEXT;
    }
}
#endif