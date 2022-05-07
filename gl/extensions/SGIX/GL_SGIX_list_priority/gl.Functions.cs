#if (GL_SGIX_list_priority && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetListParameterfvSGIX(GLuint list, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLfloat*, void> glGetListParameterfvSGIX;

        /// <summary>void glGetListParameterivSGIX(GLuint list, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLint*, void> glGetListParameterivSGIX;

        /// <summary>void glListParameterfSGIX(GLuint list, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLfloat, void> glListParameterfSGIX;

        /// <summary>void glListParameterfvSGIX(GLuint list, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLfloat*, void> glListParameterfvSGIX;

        /// <summary>void glListParameteriSGIX(GLuint list, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLint, void> glListParameteriSGIX;

        /// <summary>void glListParameterivSGIX(GLuint list, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ListParameterName, GLint*, void> glListParameterivSGIX;
    }
}
#endif