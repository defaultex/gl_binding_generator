#if (GL_NV_gpu_program5 && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetProgramSubroutineParameteruivNV(GLenum target, GLuint index, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint*, void> glGetProgramSubroutineParameteruivNV;

        /// <summary>void glProgramSubroutineParametersuivNV(GLenum target, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, GLuint*, void> glProgramSubroutineParametersuivNV;
    }
}
#endif