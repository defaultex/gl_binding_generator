#if (GL_VERSION_1_3 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glActiveTexture(GLenum texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;

#endif

        /// <summary>void glClientActiveTexture(GLenum texture)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glClientActiveTexture;

        /// <summary>void glCompressedTexImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage1D;

#if !GL_ES_VERSION_2_0

        /// <summary>void glCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glCompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage3D;

#endif

        /// <summary>void glCompressedTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage1D;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glCompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const void* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage3D;

#endif

        /// <summary>void glGetCompressedTexImage(GLenum target, GLint level, void* img)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, void*, void> glGetCompressedTexImage;

        /// <summary>void glLoadTransposeMatrixd(const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glLoadTransposeMatrixd;

        /// <summary>void glLoadTransposeMatrixf(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadTransposeMatrixf;

        /// <summary>void glMultTransposeMatrixd(const GLdouble* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glMultTransposeMatrixd;

        /// <summary>void glMultTransposeMatrixf(const GLfloat* m)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultTransposeMatrixf;

        /// <summary>void glMultiTexCoord1d(GLenum target, GLdouble s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, void> glMultiTexCoord1d;

        /// <summary>void glMultiTexCoord1dv(GLenum target, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord1dv;

        /// <summary>void glMultiTexCoord1f(GLenum target, GLfloat s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, void> glMultiTexCoord1f;

        /// <summary>void glMultiTexCoord1fv(GLenum target, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord1fv;

        /// <summary>void glMultiTexCoord1i(GLenum target, GLint s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, void> glMultiTexCoord1i;

        /// <summary>void glMultiTexCoord1iv(GLenum target, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord1iv;

        /// <summary>void glMultiTexCoord1s(GLenum target, GLshort s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, void> glMultiTexCoord1s;

        /// <summary>void glMultiTexCoord1sv(GLenum target, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord1sv;

        /// <summary>void glMultiTexCoord2d(GLenum target, GLdouble s, GLdouble t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, void> glMultiTexCoord2d;

        /// <summary>void glMultiTexCoord2dv(GLenum target, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord2dv;

        /// <summary>void glMultiTexCoord2f(GLenum target, GLfloat s, GLfloat t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, void> glMultiTexCoord2f;

        /// <summary>void glMultiTexCoord2fv(GLenum target, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord2fv;

        /// <summary>void glMultiTexCoord2i(GLenum target, GLint s, GLint t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, void> glMultiTexCoord2i;

        /// <summary>void glMultiTexCoord2iv(GLenum target, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord2iv;

        /// <summary>void glMultiTexCoord2s(GLenum target, GLshort s, GLshort t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, void> glMultiTexCoord2s;

        /// <summary>void glMultiTexCoord2sv(GLenum target, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord2sv;

        /// <summary>void glMultiTexCoord3d(GLenum target, GLdouble s, GLdouble t, GLdouble r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord3d;

        /// <summary>void glMultiTexCoord3dv(GLenum target, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord3dv;

        /// <summary>void glMultiTexCoord3f(GLenum target, GLfloat s, GLfloat t, GLfloat r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord3f;

        /// <summary>void glMultiTexCoord3fv(GLenum target, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord3fv;

        /// <summary>void glMultiTexCoord3i(GLenum target, GLint s, GLint t, GLint r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, void> glMultiTexCoord3i;

        /// <summary>void glMultiTexCoord3iv(GLenum target, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord3iv;

        /// <summary>void glMultiTexCoord3s(GLenum target, GLshort s, GLshort t, GLshort r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, void> glMultiTexCoord3s;

        /// <summary>void glMultiTexCoord3sv(GLenum target, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord3sv;

        /// <summary>void glMultiTexCoord4d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord4d;

        /// <summary>void glMultiTexCoord4dv(GLenum target, const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord4dv;

        /// <summary>void glMultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord4f;

        /// <summary>void glMultiTexCoord4fv(GLenum target, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord4fv;

        /// <summary>void glMultiTexCoord4i(GLenum target, GLint s, GLint t, GLint r, GLint q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, GLint, void> glMultiTexCoord4i;

        /// <summary>void glMultiTexCoord4iv(GLenum target, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord4iv;

        /// <summary>void glMultiTexCoord4s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, GLshort, void> glMultiTexCoord4s;

        /// <summary>void glMultiTexCoord4sv(GLenum target, const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord4sv;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)

        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;

#endif
    }
}
#endif