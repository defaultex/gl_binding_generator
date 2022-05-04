#if (GL_OES_draw_texture && GLES1_API)
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexfOES(GLfloat x, GLfloat y, GLfloat z, GLfloat width, GLfloat height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glDrawTexfOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexfvOES(GLfloat* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glDrawTexfvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexiOES(GLint x, GLint y, GLint z, GLint width, GLint height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glDrawTexiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexivOES(GLint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glDrawTexivOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexsOES(GLshort x, GLshort y, GLshort z, GLshort width, GLshort height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, GLshort, GLshort, void> glDrawTexsOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexsvOES(GLshort* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glDrawTexsvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexxOES(GLfixed x, GLfixed y, GLfixed z, GLfixed width, GLfixed height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glDrawTexxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawTexxvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glDrawTexxvOES;
#endif
    }
}
#endif