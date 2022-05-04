#if (GL_VERSION_1_3 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glActiveTexture(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClientActiveTexture(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glClientActiveTexture;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage1D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage3D;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetCompressedTexImage(GLenum target, GLint level, void* img);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, void*, void> glGetCompressedTexImage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLoadTransposeMatrixd(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glLoadTransposeMatrixd;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLoadTransposeMatrixf(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glLoadTransposeMatrixf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1d(GLenum target, GLdouble s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, void> glMultiTexCoord1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1dv(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord1dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1f(GLenum target, GLfloat s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, void> glMultiTexCoord1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1fv(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1i(GLenum target, GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, void> glMultiTexCoord1i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1iv(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord1iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1s(GLenum target, GLshort s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, void> glMultiTexCoord1s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord1sv(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord1sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2d(GLenum target, GLdouble s, GLdouble t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, void> glMultiTexCoord2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2dv(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2f(GLenum target, GLfloat s, GLfloat t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, void> glMultiTexCoord2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2fv(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2i(GLenum target, GLint s, GLint t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, void> glMultiTexCoord2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2iv(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2s(GLenum target, GLshort s, GLshort t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, void> glMultiTexCoord2s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord2sv(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord2sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3d(GLenum target, GLdouble s, GLdouble t, GLdouble r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3dv(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3f(GLenum target, GLfloat s, GLfloat t, GLfloat r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3fv(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3i(GLenum target, GLint s, GLint t, GLint r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, void> glMultiTexCoord3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3iv(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3s(GLenum target, GLshort s, GLshort t, GLshort r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, void> glMultiTexCoord3s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord3sv(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord3sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4dv(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4fv(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4i(GLenum target, GLint s, GLint t, GLint r, GLint q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, GLint, void> glMultiTexCoord4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4iv(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, GLshort, void> glMultiTexCoord4s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoord4sv(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord4sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultTransposeMatrixd(GLdouble* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glMultTransposeMatrixd;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultTransposeMatrixf(GLfloat* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glMultTransposeMatrixf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSampleCoverage(GLfloat value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;
#endif
    }
}
#endif