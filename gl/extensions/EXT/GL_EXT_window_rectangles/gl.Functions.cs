#if (GL_EXT_window_rectangles && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glWindowRectanglesEXT(GLenum mode, GLsizei count, const GLint* box)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, GLint*, void> glWindowRectanglesEXT;
    }
}
#endif