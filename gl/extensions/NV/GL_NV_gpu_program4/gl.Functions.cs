#if (GL_NV_gpu_program4 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramEnvParameterIivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glGetProgramEnvParameterIivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramEnvParameterIuivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glGetProgramEnvParameterIuivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramLocalParameterIivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glGetProgramLocalParameterIivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramLocalParameterIuivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glGetProgramLocalParameterIuivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint, GLint, GLint, GLint, void> glProgramEnvParameterI4iNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameterI4ivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glProgramEnvParameterI4ivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLuint, GLuint, GLuint, void> glProgramEnvParameterI4uiNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameterI4uivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glProgramEnvParameterI4uivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLint*, void> glProgramEnvParametersI4ivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLuint*, void> glProgramEnvParametersI4uivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint, GLint, GLint, GLint, void> glProgramLocalParameterI4iNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameterI4ivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glProgramLocalParameterI4ivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLuint, GLuint, GLuint, void> glProgramLocalParameterI4uiNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameterI4uivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glProgramLocalParameterI4uivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLint*, void> glProgramLocalParametersI4ivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLuint*, void> glProgramLocalParametersI4uivNV;
#endif
    }
}
#endif