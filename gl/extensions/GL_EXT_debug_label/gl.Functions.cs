#if GL_EXT_debug_label

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabelEXT;
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLchar*, void> glLabelObjectEXT;
    }
}

#endif