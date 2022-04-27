#if (GL_SUN_global_alpha && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGlobalAlphaFactorbSUN(GLbyte factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, void> glGlobalAlphaFactorbSUN;

        /// <summary>void glGlobalAlphaFactordSUN(GLdouble factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glGlobalAlphaFactordSUN;

        /// <summary>void glGlobalAlphaFactorfSUN(GLfloat factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glGlobalAlphaFactorfSUN;

        /// <summary>void glGlobalAlphaFactoriSUN(GLint factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glGlobalAlphaFactoriSUN;

        /// <summary>void glGlobalAlphaFactorsSUN(GLshort factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, void> glGlobalAlphaFactorsSUN;

        /// <summary>void glGlobalAlphaFactorubSUN(GLubyte factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, void> glGlobalAlphaFactorubSUN;

        /// <summary>void glGlobalAlphaFactoruiSUN(GLuint factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glGlobalAlphaFactoruiSUN;

        /// <summary>void glGlobalAlphaFactorusSUN(GLushort factor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, void> glGlobalAlphaFactorusSUN;
    }
}
#endif