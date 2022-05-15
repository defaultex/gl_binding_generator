#if GL_ARB_viewport_array

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glDepthRangeArraydvNV(GLuint first, GLsizei count, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glDepthRangeArraydvNV;

        /// <summary>void glDepthRangeIndexeddNV(GLuint index, GLdouble n, GLdouble f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glDepthRangeIndexeddNV;
    }
}

#endif