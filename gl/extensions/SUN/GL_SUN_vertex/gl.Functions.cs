#if (GL_SUN_vertex && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColor3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glColor3fVertex3fSUN;

        /// <summary>void glColor3fVertex3fvSUN(const GLfloat* c, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glColor3fVertex3fvSUN;

        /// <summary>void glColor4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glColor4fNormal3fVertex3fSUN;

        /// <summary>void glColor4fNormal3fVertex3fvSUN(const GLfloat* c, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, void> glColor4fNormal3fVertex3fvSUN;

        /// <summary>void glColor4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, void> glColor4ubVertex2fSUN;

        /// <summary>void glColor4ubVertex2fvSUN(const GLubyte* c, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, GLfloat*, void> glColor4ubVertex2fvSUN;

        /// <summary>void glColor4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat, void> glColor4ubVertex3fSUN;

        /// <summary>void glColor4ubVertex3fvSUN(const GLubyte* c, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, GLfloat*, void> glColor4ubVertex3fvSUN;

        /// <summary>void glNormal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glNormal3fVertex3fSUN;

        /// <summary>void glNormal3fVertex3fvSUN(const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glNormal3fVertex3fvSUN;

        /// <summary>void glReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiColor3fVertex3fSUN;

        /// <summary>void glReplacementCodeuiColor3fVertex3fvSUN(const GLuint* rc, const GLfloat* c, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, void> glReplacementCodeuiColor3fVertex3fvSUN;

        /// <summary>void glReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiColor4fNormal3fVertex3fSUN;

        /// <summary>void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(const GLuint* rc, const GLfloat* c, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, GLfloat*, void> glReplacementCodeuiColor4fNormal3fVertex3fvSUN;

        /// <summary>void glReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiColor4ubVertex3fSUN;

        /// <summary>void glReplacementCodeuiColor4ubVertex3fvSUN(const GLuint* rc, const GLubyte* c, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLubyte*, GLfloat*, void> glReplacementCodeuiColor4ubVertex3fvSUN;

        /// <summary>void glReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiNormal3fVertex3fSUN;

        /// <summary>void glReplacementCodeuiNormal3fVertex3fvSUN(const GLuint* rc, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, void> glReplacementCodeuiNormal3fVertex3fvSUN;

        /// <summary>void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;

        /// <summary>void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(const GLuint* rc, const GLfloat* tc, const GLfloat* c, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, GLfloat*, GLfloat*, void> glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;

        /// <summary>void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;

        /// <summary>void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(const GLuint* rc, const GLfloat* tc, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, GLfloat*, void> glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;

        /// <summary>void glReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiTexCoord2fVertex3fSUN;

        /// <summary>void glReplacementCodeuiTexCoord2fVertex3fvSUN(const GLuint* rc, const GLfloat* tc, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, void> glReplacementCodeuiTexCoord2fVertex3fvSUN;

        /// <summary>void glReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiVertex3fSUN;

        /// <summary>void glReplacementCodeuiVertex3fvSUN(const GLuint* rc, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, void> glReplacementCodeuiVertex3fvSUN;

        /// <summary>void glTexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fColor3fVertex3fSUN;

        /// <summary>void glTexCoord2fColor3fVertex3fvSUN(const GLfloat* tc, const GLfloat* c, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, void> glTexCoord2fColor3fVertex3fvSUN;

        /// <summary>void glTexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fColor4fNormal3fVertex3fSUN;

        /// <summary>void glTexCoord2fColor4fNormal3fVertex3fvSUN(const GLfloat* tc, const GLfloat* c, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, GLfloat*, void> glTexCoord2fColor4fNormal3fVertex3fvSUN;

        /// <summary>void glTexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat, void> glTexCoord2fColor4ubVertex3fSUN;

        /// <summary>void glTexCoord2fColor4ubVertex3fvSUN(const GLfloat* tc, const GLubyte* c, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLubyte*, GLfloat*, void> glTexCoord2fColor4ubVertex3fvSUN;

        /// <summary>void glTexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fNormal3fVertex3fSUN;

        /// <summary>void glTexCoord2fNormal3fVertex3fvSUN(const GLfloat* tc, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, void> glTexCoord2fNormal3fVertex3fvSUN;

        /// <summary>void glTexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fVertex3fSUN;

        /// <summary>void glTexCoord2fVertex3fvSUN(const GLfloat* tc, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glTexCoord2fVertex3fvSUN;

        /// <summary>void glTexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord4fColor4fNormal3fVertex4fSUN;

        /// <summary>void glTexCoord4fColor4fNormal3fVertex4fvSUN(const GLfloat* tc, const GLfloat* c, const GLfloat* n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, GLfloat*, void> glTexCoord4fColor4fNormal3fVertex4fvSUN;

        /// <summary>void glTexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord4fVertex4fSUN;

        /// <summary>void glTexCoord4fVertex4fvSUN(const GLfloat* tc, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glTexCoord4fVertex4fvSUN;
    }
}
#endif