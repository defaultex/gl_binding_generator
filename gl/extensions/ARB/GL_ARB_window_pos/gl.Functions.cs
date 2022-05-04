#if (GL_ARB_window_pos && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2dARB(GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glWindowPos2dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2dvARB(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos2dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2fARB(GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glWindowPos2fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2fvARB(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos2fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2iARB(GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glWindowPos2iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2ivARB(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos2ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2sARB(GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glWindowPos2sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2svARB(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos2svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3dARB(GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glWindowPos3dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3dvARB(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos3dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3fARB(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glWindowPos3fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3fvARB(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos3fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3iARB(GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glWindowPos3iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3ivARB(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos3ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3sARB(GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glWindowPos3sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3svARB(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos3svARB;
#endif
    }
}
#endif