#if (GL_ARB_multitexture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glActiveTextureARB(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTextureARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClientActiveTextureARB(GLenum texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glClientActiveTextureARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1dARB(GLenum target, GLdouble s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, void> glMultiTexCoord1dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord1dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1fARB(GLenum target, GLfloat s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, void> glMultiTexCoord1fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord1fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1iARB(GLenum target, GLint s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, void> glMultiTexCoord1iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord1ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1sARB(GLenum target, GLshort s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, void> glMultiTexCoord1sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord1svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2dARB(GLenum target, GLdouble s, GLdouble t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, void> glMultiTexCoord2dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord2dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2fARB(GLenum target, GLfloat s, GLfloat t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, void> glMultiTexCoord2fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord2fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2iARB(GLenum target, GLint s, GLint t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, void> glMultiTexCoord2iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord2ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2sARB(GLenum target, GLshort s, GLshort t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, void> glMultiTexCoord2sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord2svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord3dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord3dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord3fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord3fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3iARB(GLenum target, GLint s, GLint t, GLint r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, void> glMultiTexCoord3iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord3ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3sARB(GLenum target, GLshort s, GLshort t, GLshort r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, void> glMultiTexCoord3sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord3svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble, GLdouble, GLdouble, GLdouble, void> glMultiTexCoord4dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4dvARB(GLenum target, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLdouble*, void> glMultiTexCoord4dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat, GLfloat, GLfloat, GLfloat, void> glMultiTexCoord4fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4fvARB(GLenum target, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfloat*, void> glMultiTexCoord4fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4iARB(GLenum target, GLint s, GLint t, GLint r, GLint q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint, GLint, GLint, GLint, void> glMultiTexCoord4iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4ivARB(GLenum target, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLint*, void> glMultiTexCoord4ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4sARB(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort, GLshort, GLshort, GLshort, void> glMultiTexCoord4sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4svARB(GLenum target, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLshort*, void> glMultiTexCoord4svARB;
#endif
    }
}
#endif