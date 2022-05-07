#if (GL_QCOM_binning_control && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0;
        public const GLenum GL_CPU_OPTIMIZED_QCOM = 0x8FB1;
        public const GLenum GL_GPU_OPTIMIZED_QCOM = 0x8FB2;
        public const GLenum GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM = 0x8FB3;
    }
}
#endif