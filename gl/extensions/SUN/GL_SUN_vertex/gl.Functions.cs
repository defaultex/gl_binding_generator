#if (GL_SUN_vertex && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glColor3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor3fVertex3fvSUN(GLfloat* c, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glColor3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glColor4fNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, void> glColor4fNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, void> glColor4ubVertex2fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4ubVertex2fvSUN(GLubyte* c, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, GLfloat*, void> glColor4ubVertex2fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat, void> glColor4ubVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4ubVertex3fvSUN(GLubyte* c, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, GLfloat*, void> glColor4ubVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormal3fVertex3fvSUN(GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiColor3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, void> glReplacementCodeuiColor3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiColor4fNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, GLfloat*, void> glReplacementCodeuiColor4fNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiColor4ubVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLubyte*, GLfloat*, void> glReplacementCodeuiColor4ubVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, void> glReplacementCodeuiNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, GLfloat*, GLfloat*, void> glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, GLfloat*, void> glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiTexCoord2fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, GLfloat*, void> glReplacementCodeuiTexCoord2fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glReplacementCodeuiVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReplacementCodeuiVertex3fvSUN(GLuint* rc, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, GLfloat*, void> glReplacementCodeuiVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fColor3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, void> glTexCoord2fColor3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fColor4fNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, GLfloat*, void> glTexCoord2fColor4fNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat, void> glTexCoord2fColor4ubVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLubyte*, GLfloat*, void> glTexCoord2fColor4ubVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fNormal3fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, void> glTexCoord2fNormal3fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord2fVertex3fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2fVertex3fvSUN(GLfloat* tc, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glTexCoord2fVertex3fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord4fColor4fNormal3fVertex4fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, GLfloat*, GLfloat*, void> glTexCoord4fColor4fNormal3fVertex4fvSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glTexCoord4fVertex4fSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4fVertex4fvSUN(GLfloat* tc, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, GLfloat*, void> glTexCoord4fVertex4fvSUN;
#endif
    }
}
#endif