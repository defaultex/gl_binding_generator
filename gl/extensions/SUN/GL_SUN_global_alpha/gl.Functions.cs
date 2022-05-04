#if (GL_SUN_global_alpha && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactorbSUN(GLbyte factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, void> glGlobalAlphaFactorbSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactordSUN(GLdouble factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glGlobalAlphaFactordSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactorfSUN(GLfloat factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glGlobalAlphaFactorfSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactoriSUN(GLint factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glGlobalAlphaFactoriSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactorsSUN(GLshort factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, void> glGlobalAlphaFactorsSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactorubSUN(GLubyte factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, void> glGlobalAlphaFactorubSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactoruiSUN(GLuint factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glGlobalAlphaFactoruiSUN;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGlobalAlphaFactorusSUN(GLushort factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, void> glGlobalAlphaFactorusSUN;
#endif
    }
}
#endif