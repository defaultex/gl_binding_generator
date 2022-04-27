#if (GL_ARB_vertex_program && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindProgramARB(GLenum target, GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLprogram, void> glBindProgramARB;

        /// <summary>void glDeleteProgramsARB(GLsizei n, const GLuint* programs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, void> glDeleteProgramsARB;

        /// <summary>void glDisableVertexAttribArrayARB(GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArrayARB;

        /// <summary>void glEnableVertexAttribArrayARB(GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArrayARB;

        /// <summary>void glGenProgramsARB(GLsizei n, GLuint* programs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, void> glGenProgramsARB;

        /// <summary>void glGetProgramEnvParameterdvARB(GLenum target, GLuint index, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glGetProgramEnvParameterdvARB;

        /// <summary>void glGetProgramEnvParameterfvARB(GLenum target, GLuint index, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glGetProgramEnvParameterfvARB;

        /// <summary>void glGetProgramLocalParameterdvARB(GLenum target, GLuint index, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glGetProgramLocalParameterdvARB;

        /// <summary>void glGetProgramLocalParameterfvARB(GLenum target, GLuint index, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glGetProgramLocalParameterfvARB;

        /// <summary>void glGetProgramStringARB(GLenum target, GLenum pname, void* string)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramStringProperty, void*, void> glGetProgramStringARB;

        /// <summary>void glGetProgramivARB(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramPropertyARB, GLint*, void> glGetProgramivARB;

        /// <summary>void glGetVertexAttribPointervARB(GLuint index, GLenum pname, void** pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointervARB;

        /// <summary>void glGetVertexAttribdvARB(GLuint index, GLenum pname, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLdouble*, void> glGetVertexAttribdvARB;

        /// <summary>void glGetVertexAttribfvARB(GLuint index, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfvARB;

        /// <summary>void glGetVertexAttribivARB(GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribivARB;

        /// <summary>GLboolean glIsProgramARB(GLuint program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLboolean> glIsProgramARB;

        /// <summary>void glProgramEnvParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramEnvParameter4dARB;

        /// <summary>void glProgramEnvParameter4dvARB(GLenum target, GLuint index, const GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glProgramEnvParameter4dvARB;

        /// <summary>void glProgramEnvParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramEnvParameter4fARB;

        /// <summary>void glProgramEnvParameter4fvARB(GLenum target, GLuint index, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glProgramEnvParameter4fvARB;

        /// <summary>void glProgramLocalParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramLocalParameter4dARB;

        /// <summary>void glProgramLocalParameter4dvARB(GLenum target, GLuint index, const GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glProgramLocalParameter4dvARB;

        /// <summary>void glProgramLocalParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramLocalParameter4fARB;

        /// <summary>void glProgramLocalParameter4fvARB(GLenum target, GLuint index, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glProgramLocalParameter4fvARB;

        /// <summary>void glProgramStringARB(GLenum target, GLenum format, GLsizei len, const void* string)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramFormat, GLsizei, void*, void> glProgramStringARB;

        /// <summary>void glVertexAttrib1dARB(GLuint index, GLdouble x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttrib1dARB;

        /// <summary>void glVertexAttrib1dvARB(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib1dvARB;

        /// <summary>void glVertexAttrib1fARB(GLuint index, GLfloat x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1fARB;

        /// <summary>void glVertexAttrib1fvARB(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fvARB;

        /// <summary>void glVertexAttrib1sARB(GLuint index, GLshort x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, void> glVertexAttrib1sARB;

        /// <summary>void glVertexAttrib1svARB(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib1svARB;

        /// <summary>void glVertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttrib2dARB;

        /// <summary>void glVertexAttrib2dvARB(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib2dvARB;

        /// <summary>void glVertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2fARB;

        /// <summary>void glVertexAttrib2fvARB(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fvARB;

        /// <summary>void glVertexAttrib2sARB(GLuint index, GLshort x, GLshort y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, void> glVertexAttrib2sARB;

        /// <summary>void glVertexAttrib2svARB(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib2svARB;

        /// <summary>void glVertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttrib3dARB;

        /// <summary>void glVertexAttrib3dvARB(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib3dvARB;

        /// <summary>void glVertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3fARB;

        /// <summary>void glVertexAttrib3fvARB(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fvARB;

        /// <summary>void glVertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, void> glVertexAttrib3sARB;

        /// <summary>void glVertexAttrib3svARB(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib3svARB;

        /// <summary>void glVertexAttrib4NbvARB(GLuint index, const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4NbvARB;

        /// <summary>void glVertexAttrib4NivARB(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4NivARB;

        /// <summary>void glVertexAttrib4NsvARB(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4NsvARB;

        /// <summary>void glVertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, void> glVertexAttrib4NubARB;

        /// <summary>void glVertexAttrib4NubvARB(GLuint index, const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4NubvARB;

        /// <summary>void glVertexAttrib4NuivARB(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4NuivARB;

        /// <summary>void glVertexAttrib4NusvARB(GLuint index, const GLushort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4NusvARB;

        /// <summary>void glVertexAttrib4bvARB(GLuint index, const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4bvARB;

        /// <summary>void glVertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttrib4dARB;

        /// <summary>void glVertexAttrib4dvARB(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib4dvARB;

        /// <summary>void glVertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4fARB;

        /// <summary>void glVertexAttrib4fvARB(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fvARB;

        /// <summary>void glVertexAttrib4ivARB(GLuint index, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4ivARB;

        /// <summary>void glVertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, GLshort, void> glVertexAttrib4sARB;

        /// <summary>void glVertexAttrib4svARB(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4svARB;

        /// <summary>void glVertexAttrib4ubvARB(GLuint index, const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4ubvARB;

        /// <summary>void glVertexAttrib4uivARB(GLuint index, const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4uivARB;

        /// <summary>void glVertexAttrib4usvARB(GLuint index, const GLushort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4usvARB;

        /// <summary>void glVertexAttribPointerARB(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointerARB;
    }
}
#endif