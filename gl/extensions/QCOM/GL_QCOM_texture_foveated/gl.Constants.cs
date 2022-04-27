#if (GL_QCOM_texture_foveated && GLES2_API)
public partial class glext_qcom { 
    public partial class Constants { 
        public const GLenum GL_FOVEATION_ENABLE_BIT_QCOM = 0x00000001;
        public const GLenum GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;
        public const GLenum GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM = 0x8BFB;
        public const GLenum GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM = 0x8BFC;
        public const GLenum GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM = 0x8BFD;
        public const GLenum GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM = 0x8BFE;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM = 0x8BFF;
    }
}
#endif