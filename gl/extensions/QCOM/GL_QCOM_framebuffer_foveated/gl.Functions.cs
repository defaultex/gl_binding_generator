#if (GL_QCOM_framebuffer_foveated && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glFramebufferFoveationConfigQCOM(GLuint framebuffer, GLuint numLayers, GLuint focalPointsPerLayer, GLuint requestedFeatures, GLuint* providedFeatures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLuint, GLuint, GLuint, GLuint*, void> glFramebufferFoveationConfigQCOM;

        /// <summary>void glFramebufferFoveationParametersQCOM(GLuint framebuffer, GLuint layer, GLuint focalPoint, GLfloat focalX, GLfloat focalY, GLfloat gainX, GLfloat gainY, GLfloat foveaArea);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLuint, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, void> glFramebufferFoveationParametersQCOM;
    }
}
#endif