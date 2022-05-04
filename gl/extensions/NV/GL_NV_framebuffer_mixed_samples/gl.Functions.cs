#if (GL_NV_framebuffer_mixed_samples && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverageModulationNV(GLenum components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glCoverageModulationNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCoverageModulationTableNV(GLsizei n, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glCoverageModulationTableNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCoverageModulationTableNV(GLsizei bufSize, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glGetCoverageModulationTableNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRasterSamplesEXT(GLuint samples, GLboolean fixedsamplelocations);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, void> glRasterSamplesEXT;
#endif
    }
}
#endif