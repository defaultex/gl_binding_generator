#if (GL_NV_gpu_program5 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramSubroutineParameteruivNV(GLenum target, GLuint index, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLuint*, void> glGetProgramSubroutineParameteruivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramSubroutineParametersuivNV(GLenum target, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLsizei, GLuint*, void> glProgramSubroutineParametersuivNV;
#endif
    }
}
#endif