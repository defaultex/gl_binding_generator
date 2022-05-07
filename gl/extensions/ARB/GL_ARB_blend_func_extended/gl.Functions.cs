#if (GL_ARB_blend_func_extended && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexed;

        /// <summary>GLint glGetFragDataIndex(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataIndex;
    }
}
#endif