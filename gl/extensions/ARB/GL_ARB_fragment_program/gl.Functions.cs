#if (GL_ARB_fragment_program && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindProgramARB(GLenum target, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, program, void> glBindProgramARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteProgramsARB(GLsizei n, GLuint* programs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, program*, void> glDeleteProgramsARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenProgramsARB(GLsizei n, GLuint* programs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, program*, void> glGenProgramsARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramEnvParameterdvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glGetProgramEnvParameterdvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramEnvParameterfvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glGetProgramEnvParameterfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramivARB(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramPropertyARB, GLint*, void> glGetProgramivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramLocalParameterdvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glGetProgramLocalParameterdvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramLocalParameterfvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glGetProgramLocalParameterfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramStringARB(GLenum target, GLenum pname, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramStringProperty, void*, void> glGetProgramStringARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsProgramARB(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLboolean> glIsProgramARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramEnvParameter4dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameter4dvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glProgramEnvParameter4dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramEnvParameter4fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameter4fvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glProgramEnvParameter4fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramLocalParameter4dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameter4dvARB(GLenum target, GLuint index, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLdouble*, void> glProgramLocalParameter4dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramLocalParameter4fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameter4fvARB(GLenum target, GLuint index, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLfloat*, void> glProgramLocalParameter4fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramStringARB(GLenum target, GLenum format, GLsizei len, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, ProgramFormat, GLsizei, void*, void> glProgramStringARB;
#endif
    }
}
#endif