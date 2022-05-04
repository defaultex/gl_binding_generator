#if (GL_QCOM_framebuffer_foveated && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferFoveationConfigQCOM(GLuint framebuffer, GLuint numLayers, GLuint focalPointsPerLayer, GLuint requestedFeatures, GLuint* providedFeatures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLuint, GLuint, GLuint, GLuint*, void> glFramebufferFoveationConfigQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferFoveationParametersQCOM(GLuint framebuffer, GLuint layer, GLuint focalPoint, GLfloat focalX, GLfloat focalY, GLfloat gainX, GLfloat gainY, GLfloat foveaArea);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLuint, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glFramebufferFoveationParametersQCOM;
#endif
    }
}
#endif