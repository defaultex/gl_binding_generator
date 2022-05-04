#if (GL_QCOM_motion_estimation && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexEstimateMotionQCOM(GLuint ref, GLuint target, GLuint output);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, texture, texture, void> glTexEstimateMotionQCOM;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexEstimateMotionRegionsQCOM(GLuint ref, GLuint target, GLuint output, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, texture, texture, texture, void> glTexEstimateMotionRegionsQCOM;
#endif
    }
}
#endif