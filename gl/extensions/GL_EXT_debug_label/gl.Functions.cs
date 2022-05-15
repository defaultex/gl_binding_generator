#if GL_EXT_debug_label

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glGetObjectLabelEXT(GLenum type, GLuint object, GLsizei bufSize, GLsizei* length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetObjectLabelEXT;

        /// <summary>void glLabelObjectEXT(GLenum type, GLuint object, GLsizei length, GLchar* label);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLsizei, GLchar*, void> glLabelObjectEXT;
    }
}

#endif