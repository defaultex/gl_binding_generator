#if (GL_NV_fragment_program && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramNamedParameterdvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLubyte*, GLdouble*, void> glGetProgramNamedParameterdvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramNamedParameterfvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLubyte*, GLfloat*, void> glGetProgramNamedParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramNamedParameter4dNV(GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLubyte*, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramNamedParameter4dNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramNamedParameter4dvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLubyte*, GLdouble*, void> glProgramNamedParameter4dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramNamedParameter4fNV(GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLubyte*, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramNamedParameter4fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramNamedParameter4fvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLubyte*, GLfloat*, void> glProgramNamedParameter4fvNV;
#endif
    }
}
#endif