#if (GL_ARB_vertex_shader && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindAttribLocationARB(GLhandleARB programObj, GLuint index, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLuint, GLcharARB*, void> glBindAttribLocationARB;

        /// <summary>void glGetActiveAttribARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLuint, GLsizei, GLsizei*, GLint*, AttributeType*, GLcharARB*, void> glGetActiveAttribARB;

        /// <summary>GLint glGetAttribLocationARB(GLhandleARB programObj, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLcharARB*, GLint> glGetAttribLocationARB;
    }
}
#endif