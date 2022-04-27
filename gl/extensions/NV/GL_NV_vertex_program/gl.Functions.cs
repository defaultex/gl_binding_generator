#if (GL_NV_vertex_program && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLboolean glAreProgramsResidentNV(GLsizei n, const GLuint* programs, GLboolean* residences)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, GLboolean*, GLboolean> glAreProgramsResidentNV;

        /// <summary>void glBindProgramNV(GLenum target, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLprogram, void> glBindProgramNV;

        /// <summary>void glDeleteProgramsNV(GLsizei n, const GLuint* programs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, void> glDeleteProgramsNV;

        /// <summary>void glExecuteProgramNV(GLenum target, GLuint id, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLfloat*, void> glExecuteProgramNV;

        /// <summary>void glGenProgramsNV(GLsizei n, GLuint* programs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, void> glGenProgramsNV;

        /// <summary>void glGetProgramParameterdvNV(GLenum target, GLuint index, GLenum pname, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, GLdouble*, void> glGetProgramParameterdvNV;

        /// <summary>void glGetProgramParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, GLfloat*, void> glGetProgramParameterfvNV;

        /// <summary>void glGetProgramStringNV(GLuint id, GLenum pname, GLubyte* program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, VertexAttribEnumNV, GLubyte*, void> glGetProgramStringNV;

        /// <summary>void glGetProgramivNV(GLuint id, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, VertexAttribEnumNV, GLint*, void> glGetProgramivNV;

        /// <summary>void glGetTrackMatrixivNV(GLenum target, GLuint address, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, GLint*, void> glGetTrackMatrixivNV;

        /// <summary>void glGetVertexAttribPointervNV(GLuint index, GLenum pname, void** pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, void**, void> glGetVertexAttribPointervNV;

        /// <summary>void glGetVertexAttribdvNV(GLuint index, GLenum pname, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, GLdouble*, void> glGetVertexAttribdvNV;

        /// <summary>void glGetVertexAttribfvNV(GLuint index, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, GLfloat*, void> glGetVertexAttribfvNV;

        /// <summary>void glGetVertexAttribivNV(GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, GLint*, void> glGetVertexAttribivNV;

        /// <summary>GLboolean glIsProgramNV(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLboolean> glIsProgramNV;

        /// <summary>void glLoadProgramNV(GLenum target, GLuint id, GLsizei len, const GLubyte* program)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLsizei, GLubyte*, void> glLoadProgramNV;

        /// <summary>void glProgramParameter4dNV(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramParameter4dNV;

        /// <summary>void glProgramParameter4dvNV(GLenum target, GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLdouble*, void> glProgramParameter4dvNV;

        /// <summary>void glProgramParameter4fNV(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramParameter4fNV;

        /// <summary>void glProgramParameter4fvNV(GLenum target, GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLfloat*, void> glProgramParameter4fvNV;

        /// <summary>void glProgramParameters4dvNV(GLenum target, GLuint index, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLsizei, GLdouble*, void> glProgramParameters4dvNV;

        /// <summary>void glProgramParameters4fvNV(GLenum target, GLuint index, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLsizei, GLfloat*, void> glProgramParameters4fvNV;

        /// <summary>void glRequestResidentProgramsNV(GLsizei n, const GLuint* programs)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLprogram*, void> glRequestResidentProgramsNV;

        /// <summary>void glTrackMatrixNV(GLenum target, GLuint address, GLenum matrix, GLenum transform)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, VertexAttribEnumNV, void> glTrackMatrixNV;

        /// <summary>void glVertexAttrib1dNV(GLuint index, GLdouble x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttrib1dNV;

        /// <summary>void glVertexAttrib1dvNV(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib1dvNV;

        /// <summary>void glVertexAttrib1fNV(GLuint index, GLfloat x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1fNV;

        /// <summary>void glVertexAttrib1fvNV(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fvNV;

        /// <summary>void glVertexAttrib1sNV(GLuint index, GLshort x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, void> glVertexAttrib1sNV;

        /// <summary>void glVertexAttrib1svNV(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib1svNV;

        /// <summary>void glVertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttrib2dNV;

        /// <summary>void glVertexAttrib2dvNV(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib2dvNV;

        /// <summary>void glVertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2fNV;

        /// <summary>void glVertexAttrib2fvNV(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fvNV;

        /// <summary>void glVertexAttrib2sNV(GLuint index, GLshort x, GLshort y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, void> glVertexAttrib2sNV;

        /// <summary>void glVertexAttrib2svNV(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib2svNV;

        /// <summary>void glVertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttrib3dNV;

        /// <summary>void glVertexAttrib3dvNV(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib3dvNV;

        /// <summary>void glVertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3fNV;

        /// <summary>void glVertexAttrib3fvNV(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fvNV;

        /// <summary>void glVertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, void> glVertexAttrib3sNV;

        /// <summary>void glVertexAttrib3svNV(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib3svNV;

        /// <summary>void glVertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttrib4dNV;

        /// <summary>void glVertexAttrib4dvNV(GLuint index, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib4dvNV;

        /// <summary>void glVertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4fNV;

        /// <summary>void glVertexAttrib4fvNV(GLuint index, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fvNV;

        /// <summary>void glVertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, GLshort, void> glVertexAttrib4sNV;

        /// <summary>void glVertexAttrib4svNV(GLuint index, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4svNV;

        /// <summary>void glVertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, void> glVertexAttrib4ubNV;

        /// <summary>void glVertexAttrib4ubvNV(GLuint index, const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4ubvNV;

        /// <summary>void glVertexAttribPointerNV(GLuint index, GLint fsize, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribEnumNV, GLsizei, void*, void> glVertexAttribPointerNV;

        /// <summary>void glVertexAttribs1dvNV(GLuint index, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs1dvNV;

        /// <summary>void glVertexAttribs1fvNV(GLuint index, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs1fvNV;

        /// <summary>void glVertexAttribs1svNV(GLuint index, GLsizei count, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs1svNV;

        /// <summary>void glVertexAttribs2dvNV(GLuint index, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs2dvNV;

        /// <summary>void glVertexAttribs2fvNV(GLuint index, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs2fvNV;

        /// <summary>void glVertexAttribs2svNV(GLuint index, GLsizei count, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs2svNV;

        /// <summary>void glVertexAttribs3dvNV(GLuint index, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs3dvNV;

        /// <summary>void glVertexAttribs3fvNV(GLuint index, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs3fvNV;

        /// <summary>void glVertexAttribs3svNV(GLuint index, GLsizei count, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs3svNV;

        /// <summary>void glVertexAttribs4dvNV(GLuint index, GLsizei count, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs4dvNV;

        /// <summary>void glVertexAttribs4fvNV(GLuint index, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs4fvNV;

        /// <summary>void glVertexAttribs4svNV(GLuint index, GLsizei count, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs4svNV;

        /// <summary>void glVertexAttribs4ubvNV(GLuint index, GLsizei count, const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLubyte*, void> glVertexAttribs4ubvNV;
    }
}
#endif