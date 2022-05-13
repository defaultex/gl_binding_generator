#if GL_EXT_window_rectangles

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, GLint*, void> glWindowRectanglesEXT;
    }
}

#endif