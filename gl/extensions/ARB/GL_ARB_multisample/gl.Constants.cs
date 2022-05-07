#if (GL_ARB_multisample && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MULTISAMPLE_ARB = 0x809D;
        public const GLenum GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
        public const GLenum GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
        public const GLenum GL_SAMPLE_COVERAGE_ARB = 0x80A0;
        public const GLenum GL_SAMPLE_BUFFERS_ARB = 0x80A8;
        public const GLenum GL_SAMPLES_ARB = 0x80A9;
        public const GLenum GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
        public const GLenum GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
        public const GLenum GL_MULTISAMPLE_BIT_ARB = 0x20000000;
    }
}
#endif