#if (GL_NV_framebuffer_mixed_samples && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCoverageModulationNV(GLenum components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glCoverageModulationNV;

        /// <summary>void glCoverageModulationTableNV(GLsizei n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glCoverageModulationTableNV;

        /// <summary>void glGetCoverageModulationTableNV(GLsizei bufSize, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glGetCoverageModulationTableNV;
    }
}
#endif