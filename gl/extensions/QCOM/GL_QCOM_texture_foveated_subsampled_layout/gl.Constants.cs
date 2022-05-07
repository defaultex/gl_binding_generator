#if (GL_QCOM_texture_foveated_subsampled_layout && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM = 0x00000004;
        public const GLenum GL_MAX_SHADER_SUBSAMPLED_IMAGE_UNITS_QCOM = 0x8FA1;
    }
}
#endif