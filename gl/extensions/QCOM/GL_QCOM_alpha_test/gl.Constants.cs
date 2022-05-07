#if (GL_QCOM_alpha_test && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_ALPHA_TEST_QCOM = 0x0BC0;
        public const GLenum GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1;
        public const GLenum GL_ALPHA_TEST_REF_QCOM = 0x0BC2;
    }
}
#endif