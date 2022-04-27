#if (GL_NV_fragment_program && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetProgramNamedParameterdvNV(GLuint id, GLsizei len, const GLubyte* name, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLubyte*, GLdouble*, void> glGetProgramNamedParameterdvNV;

        /// <summary>void glGetProgramNamedParameterfvNV(GLuint id, GLsizei len, const GLubyte* name, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLubyte*, GLfloat*, void> glGetProgramNamedParameterfvNV;

        /// <summary>void glProgramNamedParameter4dNV(GLuint id, GLsizei len, const GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLubyte*, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramNamedParameter4dNV;

        /// <summary>void glProgramNamedParameter4dvNV(GLuint id, GLsizei len, const GLubyte* name, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLubyte*, GLdouble*, void> glProgramNamedParameter4dvNV;

        /// <summary>void glProgramNamedParameter4fNV(GLuint id, GLsizei len, const GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLubyte*, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramNamedParameter4fNV;

        /// <summary>void glProgramNamedParameter4fvNV(GLuint id, GLsizei len, const GLubyte* name, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLubyte*, GLfloat*, void> glProgramNamedParameter4fvNV;
    }
}
#endif