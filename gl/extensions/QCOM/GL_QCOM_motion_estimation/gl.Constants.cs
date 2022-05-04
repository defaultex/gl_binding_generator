#if (GL_QCOM_motion_estimation && GLES2_API)
public partial class qcom { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM = 0x8C90;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM = 0x8C91;
#endif
    }
}
#endif