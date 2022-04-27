#if (GL_VERSION_1_4 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glBlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glBlendEquation(GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void> glBlendEquation;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;

#endif

        /// <summary>void glFogCoordPointer(GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPointerTypeEXT, GLsizei, void*, void> glFogCoordPointer;

        /// <summary>void glFogCoordd(GLdouble coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glFogCoordd;

        /// <summary>void glFogCoorddv(const GLdouble* coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glFogCoorddv;

        /// <summary>void glFogCoordf(GLfloat coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glFogCoordf;

        /// <summary>void glFogCoordfv(const GLfloat* coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glFogCoordfv;

        /// <summary>void glMultiDrawArrays(GLenum mode, const GLint* first, const GLsizei* count, GLsizei drawcount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint*, GLsizei*, GLsizei, void> glMultiDrawArrays;

        /// <summary>void glMultiDrawElements(GLenum mode, const GLsizei* count, GLenum type, const void*const* indices, GLsizei drawcount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, DrawElementsType, void**, GLsizei, void> glMultiDrawElements;

        /// <summary>void glPointParameterf(GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat, void> glPointParameterf;

        /// <summary>void glPointParameterfv(GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfloat*, void> glPointParameterfv;

        /// <summary>void glPointParameteri(GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLint, void> glPointParameteri;

        /// <summary>void glPointParameteriv(GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLint*, void> glPointParameteriv;

        /// <summary>void glSecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glSecondaryColor3b;

        /// <summary>void glSecondaryColor3bv(const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glSecondaryColor3bv;

        /// <summary>void glSecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glSecondaryColor3d;

        /// <summary>void glSecondaryColor3dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glSecondaryColor3dv;

        /// <summary>void glSecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glSecondaryColor3f;

        /// <summary>void glSecondaryColor3fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glSecondaryColor3fv;

        /// <summary>void glSecondaryColor3i(GLint red, GLint green, GLint blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glSecondaryColor3i;

        /// <summary>void glSecondaryColor3iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glSecondaryColor3iv;

        /// <summary>void glSecondaryColor3s(GLshort red, GLshort green, GLshort blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glSecondaryColor3s;

        /// <summary>void glSecondaryColor3sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glSecondaryColor3sv;

        /// <summary>void glSecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, void> glSecondaryColor3ub;

        /// <summary>void glSecondaryColor3ubv(const GLubyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glSecondaryColor3ubv;

        /// <summary>void glSecondaryColor3ui(GLuint red, GLuint green, GLuint blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glSecondaryColor3ui;

        /// <summary>void glSecondaryColor3uiv(const GLuint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glSecondaryColor3uiv;

        /// <summary>void glSecondaryColor3us(GLushort red, GLushort green, GLushort blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, GLushort, GLushort, void> glSecondaryColor3us;

        /// <summary>void glSecondaryColor3usv(const GLushort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glSecondaryColor3usv;

        /// <summary>void glSecondaryColorPointer(GLint size, GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void*, void> glSecondaryColorPointer;

        /// <summary>void glWindowPos2d(GLdouble x, GLdouble y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glWindowPos2d;

        /// <summary>void glWindowPos2dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos2dv;

        /// <summary>void glWindowPos2f(GLfloat x, GLfloat y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glWindowPos2f;

        /// <summary>void glWindowPos2fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos2fv;

        /// <summary>void glWindowPos2i(GLint x, GLint y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glWindowPos2i;

        /// <summary>void glWindowPos2iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos2iv;

        /// <summary>void glWindowPos2s(GLshort x, GLshort y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glWindowPos2s;

        /// <summary>void glWindowPos2sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos2sv;

        /// <summary>void glWindowPos3d(GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glWindowPos3d;

        /// <summary>void glWindowPos3dv(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos3dv;

        /// <summary>void glWindowPos3f(GLfloat x, GLfloat y, GLfloat z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glWindowPos3f;

        /// <summary>void glWindowPos3fv(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos3fv;

        /// <summary>void glWindowPos3i(GLint x, GLint y, GLint z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glWindowPos3i;

        /// <summary>void glWindowPos3iv(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos3iv;

        /// <summary>void glWindowPos3s(GLshort x, GLshort y, GLshort z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glWindowPos3s;

        /// <summary>void glWindowPos3sv(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos3sv;
    }
}
#endif