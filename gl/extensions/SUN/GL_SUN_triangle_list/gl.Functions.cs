#if (GL_SUN_triangle_list && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glReplacementCodePointerSUN(GLenum type, GLsizei stride, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReplacementCodeTypeSUN, GLsizei, void**, void> glReplacementCodePointerSUN;

        /// <summary>void glReplacementCodeubSUN(GLubyte code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, void> glReplacementCodeubSUN;

        /// <summary>void glReplacementCodeubvSUN(GLubyte* code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glReplacementCodeubvSUN;

        /// <summary>void glReplacementCodeuiSUN(GLuint code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glReplacementCodeuiSUN;

        /// <summary>void glReplacementCodeuivSUN(GLuint* code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glReplacementCodeuivSUN;

        /// <summary>void glReplacementCodeusSUN(GLushort code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, void> glReplacementCodeusSUN;

        /// <summary>void glReplacementCodeusvSUN(GLushort* code);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glReplacementCodeusvSUN;
    }
}
#endif