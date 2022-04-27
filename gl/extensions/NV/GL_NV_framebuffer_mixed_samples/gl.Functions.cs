#if (GL_NV_framebuffer_mixed_samples && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCoverageModulationNV(GLenum components)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glCoverageModulationNV;

        /// <summary>void glCoverageModulationTableNV(GLsizei n, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glCoverageModulationTableNV;

        /// <summary>void glGetCoverageModulationTableNV(GLsizei bufSize, GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glGetCoverageModulationTableNV;

        /// <summary>void glRasterSamplesEXT(GLuint samples, GLboolean fixedsamplelocations)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, void> glRasterSamplesEXT;
    }
}
#endif