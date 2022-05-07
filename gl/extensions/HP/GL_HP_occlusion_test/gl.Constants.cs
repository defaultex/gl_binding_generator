#if (GL_HP_occlusion_test && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_OCCLUSION_TEST_HP = 0x8165;
        public const GLenum GL_OCCLUSION_TEST_RESULT_HP = 0x8166;
    }
}
#endif