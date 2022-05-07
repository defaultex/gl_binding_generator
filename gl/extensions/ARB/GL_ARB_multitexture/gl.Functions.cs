#if (GL_ARB_multitexture && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glActiveTextureARB(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTextureARB;

        /// <summary>void glClientActiveTextureARB(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glClientActiveTextureARB;

        /// <summary>void glMultiTexCoord1dARB(GLenum target, GLdouble s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, void> glMultiTexCoord1dARB;

        /// <summary>void glMultiTexCoord1dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord1dvARB;

        /// <summary>void glMultiTexCoord1fARB(GLenum target, GLfloat s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, void> glMultiTexCoord1fARB;

        /// <summary>void glMultiTexCoord1fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord1fvARB;

        /// <summary>void glMultiTexCoord1iARB(GLenum target, GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, void> glMultiTexCoord1iARB;

        /// <summary>void glMultiTexCoord1ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord1ivARB;

        /// <summary>void glMultiTexCoord1sARB(GLenum target, GLshort s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, void> glMultiTexCoord1sARB;

        /// <summary>void glMultiTexCoord1svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord1svARB;

        /// <summary>void glMultiTexCoord2dARB(GLenum target, GLdouble s, GLdouble t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, void> glMultiTexCoord2dARB;

        /// <summary>void glMultiTexCoord2dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord2dvARB;

        /// <summary>void glMultiTexCoord2fARB(GLenum target, GLfloat s, GLfloat t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, void> glMultiTexCoord2fARB;

        /// <summary>void glMultiTexCoord2fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord2fvARB;

        /// <summary>void glMultiTexCoord2iARB(GLenum target, GLint s, GLint t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, void> glMultiTexCoord2iARB;

        /// <summary>void glMultiTexCoord2ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord2ivARB;

        /// <summary>void glMultiTexCoord2sARB(GLenum target, GLshort s, GLshort t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, void> glMultiTexCoord2sARB;

        /// <summary>void glMultiTexCoord2svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord2svARB;

        /// <summary>void glMultiTexCoord3dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord3dARB;

        /// <summary>void glMultiTexCoord3dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord3dvARB;

        /// <summary>void glMultiTexCoord3fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord3fARB;

        /// <summary>void glMultiTexCoord3fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord3fvARB;

        /// <summary>void glMultiTexCoord3iARB(GLenum target, GLint s, GLint t, GLint r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, void> glMultiTexCoord3iARB;

        /// <summary>void glMultiTexCoord3ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord3ivARB;

        /// <summary>void glMultiTexCoord3sARB(GLenum target, GLshort s, GLshort t, GLshort r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, void> glMultiTexCoord3sARB;

        /// <summary>void glMultiTexCoord3svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord3svARB;

        /// <summary>void glMultiTexCoord4dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord4dARB;

        /// <summary>void glMultiTexCoord4dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord4dvARB;

        /// <summary>void glMultiTexCoord4fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord4fARB;

        /// <summary>void glMultiTexCoord4fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord4fvARB;

        /// <summary>void glMultiTexCoord4iARB(GLenum target, GLint s, GLint t, GLint r, GLint q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, GLint, void> glMultiTexCoord4iARB;

        /// <summary>void glMultiTexCoord4ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord4ivARB;

        /// <summary>void glMultiTexCoord4sARB(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, GLshort, void> glMultiTexCoord4sARB;

        /// <summary>void glMultiTexCoord4svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord4svARB;
    }
}
#endif