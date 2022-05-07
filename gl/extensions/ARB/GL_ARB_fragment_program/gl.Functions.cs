#if (GL_ARB_fragment_program && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindProgramARB(GLenum target, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLprogram, void> glBindProgramARB;

        /// <summary>void glDeleteProgramsARB(GLsizei n, GLuint* programs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, void> glDeleteProgramsARB;

        /// <summary>void glGenProgramsARB(GLsizei n, GLuint* programs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, void> glGenProgramsARB;

        /// <summary>void glGetProgramEnvParameterdvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glGetProgramEnvParameterdvARB;

        /// <summary>void glGetProgramEnvParameterfvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glGetProgramEnvParameterfvARB;

        /// <summary>void glGetProgramivARB(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramPropertyARB, GLint*, void> glGetProgramivARB;

        /// <summary>void glGetProgramLocalParameterdvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glGetProgramLocalParameterdvARB;

        /// <summary>void glGetProgramLocalParameterfvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glGetProgramLocalParameterfvARB;

        /// <summary>void glGetProgramStringARB(GLenum target, GLenum pname, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramStringProperty, void*, void> glGetProgramStringARB;

        /// <summary>GLboolean glIsProgramARB(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLboolean> glIsProgramARB;

        /// <summary>void glProgramEnvParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramEnvParameter4dARB;

        /// <summary>void glProgramEnvParameter4dvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glProgramEnvParameter4dvARB;

        /// <summary>void glProgramEnvParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramEnvParameter4fARB;

        /// <summary>void glProgramEnvParameter4fvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glProgramEnvParameter4fvARB;

        /// <summary>void glProgramLocalParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramLocalParameter4dARB;

        /// <summary>void glProgramLocalParameter4dvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glProgramLocalParameter4dvARB;

        /// <summary>void glProgramLocalParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramLocalParameter4fARB;

        /// <summary>void glProgramLocalParameter4fvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glProgramLocalParameter4fvARB;

        /// <summary>void glProgramStringARB(GLenum target, GLenum format, GLsizei len, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramFormat, GLsizei, void*, void> glProgramStringARB;
    }
}
#endif