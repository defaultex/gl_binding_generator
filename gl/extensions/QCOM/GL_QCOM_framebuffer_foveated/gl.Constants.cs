#if (GL_QCOM_framebuffer_foveated && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_FOVEATION_ENABLE_BIT_QCOM = 0x00000001;
        public const GLenum GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;
    }
}
#endif