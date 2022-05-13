#if GL_NV_framebuffer_mixed_samples

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glCoverageModulationNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glCoverageModulationTableNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glGetCoverageModulationTableNV;
    }
}

#endif