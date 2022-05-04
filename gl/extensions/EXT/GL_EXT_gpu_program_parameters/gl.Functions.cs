#if (GL_EXT_gpu_program_parameters && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramEnvParameters4fvEXT(GLenum target, GLuint index, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLfloat*, void> glProgramEnvParameters4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramLocalParameters4fvEXT(GLenum target, GLuint index, GLsizei count, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLuint, GLsizei, GLfloat*, void> glProgramLocalParameters4fvEXT;
#endif
    }
}
#endif