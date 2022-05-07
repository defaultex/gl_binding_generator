#if (GL_EXT_gpu_program_parameters && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glProgramEnvParameters4fvEXT(GLenum target, GLuint index, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLfloat*, void> glProgramEnvParameters4fvEXT;

        /// <summary>void glProgramLocalParameters4fvEXT(GLenum target, GLuint index, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLfloat*, void> glProgramLocalParameters4fvEXT;
    }
}
#endif