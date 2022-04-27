#if (GL_QCOM_motion_estimation && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glTexEstimateMotionQCOM(GLuint ref, GLuint target, GLuint output)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLtexture, GLtexture, void> glTexEstimateMotionQCOM;

        /// <summary>void glTexEstimateMotionRegionsQCOM(GLuint ref, GLuint target, GLuint output, GLuint mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLtexture, GLtexture, GLtexture, void> glTexEstimateMotionRegionsQCOM;
    }
}
#endif