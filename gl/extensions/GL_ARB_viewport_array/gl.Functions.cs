#if GL_ARB_viewport_array

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glDepthRangeArraydvNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glDepthRangeIndexeddNV;
    }
}

#endif