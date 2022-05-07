#if (GL_NV_gpu_program4 && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetProgramEnvParameterIivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glGetProgramEnvParameterIivNV;

        /// <summary>void glGetProgramEnvParameterIuivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glGetProgramEnvParameterIuivNV;

        /// <summary>void glGetProgramLocalParameterIivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glGetProgramLocalParameterIivNV;

        /// <summary>void glGetProgramLocalParameterIuivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glGetProgramLocalParameterIuivNV;

        /// <summary>void glProgramEnvParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint, GLint, GLint, GLint, void> glProgramEnvParameterI4iNV;

        /// <summary>void glProgramEnvParameterI4ivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glProgramEnvParameterI4ivNV;

        /// <summary>void glProgramEnvParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLuint, GLuint, GLuint, void> glProgramEnvParameterI4uiNV;

        /// <summary>void glProgramEnvParameterI4uivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glProgramEnvParameterI4uivNV;

        /// <summary>void glProgramEnvParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLint*, void> glProgramEnvParametersI4ivNV;

        /// <summary>void glProgramEnvParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLuint*, void> glProgramEnvParametersI4uivNV;

        /// <summary>void glProgramLocalParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint, GLint, GLint, GLint, void> glProgramLocalParameterI4iNV;

        /// <summary>void glProgramLocalParameterI4ivNV(GLenum target, GLuint index, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLint*, void> glProgramLocalParameterI4ivNV;

        /// <summary>void glProgramLocalParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint, GLuint, GLuint, GLuint, void> glProgramLocalParameterI4uiNV;

        /// <summary>void glProgramLocalParameterI4uivNV(GLenum target, GLuint index, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLuint*, void> glProgramLocalParameterI4uivNV;

        /// <summary>void glProgramLocalParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLint*, void> glProgramLocalParametersI4ivNV;

        /// <summary>void glProgramLocalParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLuint*, void> glProgramLocalParametersI4uivNV;
    }
}
#endif