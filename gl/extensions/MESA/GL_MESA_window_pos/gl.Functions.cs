#if (GL_MESA_window_pos && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2dMESA(GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, void> glWindowPos2dMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2dvMESA(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos2dvMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2fMESA(GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glWindowPos2fMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2fvMESA(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos2fvMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2iMESA(GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glWindowPos2iMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2ivMESA(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos2ivMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2sMESA(GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, void> glWindowPos2sMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos2svMESA(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos2svMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glWindowPos3dMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3dvMESA(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos3dvMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glWindowPos3fMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3fvMESA(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos3fvMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3iMESA(GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glWindowPos3iMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3ivMESA(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos3ivMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3sMESA(GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glWindowPos3sMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos3svMESA(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos3svMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, GLdouble, void> glWindowPos4dMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4dvMESA(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glWindowPos4dvMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glWindowPos4fMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4fvMESA(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glWindowPos4fvMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4iMESA(GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glWindowPos4iMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4ivMESA(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glWindowPos4ivMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, void> glWindowPos4sMESA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWindowPos4svMESA(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glWindowPos4svMESA;
#endif
    }
}
#endif