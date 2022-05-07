#if (GL_EXT_secondary_color && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glSecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glSecondaryColor3bEXT;

        /// <summary>void glSecondaryColor3bvEXT(GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glSecondaryColor3bvEXT;

        /// <summary>void glSecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glSecondaryColor3dEXT;

        /// <summary>void glSecondaryColor3dvEXT(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glSecondaryColor3dvEXT;

        /// <summary>void glSecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glSecondaryColor3fEXT;

        /// <summary>void glSecondaryColor3fvEXT(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glSecondaryColor3fvEXT;

        /// <summary>void glSecondaryColor3iEXT(GLint red, GLint green, GLint blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glSecondaryColor3iEXT;

        /// <summary>void glSecondaryColor3ivEXT(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glSecondaryColor3ivEXT;

        /// <summary>void glSecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glSecondaryColor3sEXT;

        /// <summary>void glSecondaryColor3svEXT(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glSecondaryColor3svEXT;

        /// <summary>void glSecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, void> glSecondaryColor3ubEXT;

        /// <summary>void glSecondaryColor3ubvEXT(GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glSecondaryColor3ubvEXT;

        /// <summary>void glSecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glSecondaryColor3uiEXT;

        /// <summary>void glSecondaryColor3uivEXT(GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glSecondaryColor3uivEXT;

        /// <summary>void glSecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, GLushort, GLushort, void> glSecondaryColor3usEXT;

        /// <summary>void glSecondaryColor3usvEXT(GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glSecondaryColor3usvEXT;

        /// <summary>void glSecondaryColorPointerEXT(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void*, void> glSecondaryColorPointerEXT;
    }
}
#endif