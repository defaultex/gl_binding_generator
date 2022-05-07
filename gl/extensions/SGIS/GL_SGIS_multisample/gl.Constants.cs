#if (GL_SGIS_multisample && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MULTISAMPLE_SGIS = 0x809D;
        public const GLenum GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E;
        public const GLenum GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F;
        public const GLenum GL_SAMPLE_MASK_SGIS = 0x80A0;
        public const GLenum GL_1PASS_SGIS = 0x80A1;
        public const GLenum GL_2PASS_0_SGIS = 0x80A2;
        public const GLenum GL_2PASS_1_SGIS = 0x80A3;
        public const GLenum GL_4PASS_0_SGIS = 0x80A4;
        public const GLenum GL_4PASS_1_SGIS = 0x80A5;
        public const GLenum GL_4PASS_2_SGIS = 0x80A6;
        public const GLenum GL_4PASS_3_SGIS = 0x80A7;
        public const GLenum GL_SAMPLE_BUFFERS_SGIS = 0x80A8;
        public const GLenum GL_SAMPLES_SGIS = 0x80A9;
        public const GLenum GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA;
        public const GLenum GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB;
        public const GLenum GL_SAMPLE_PATTERN_SGIS = 0x80AC;
    }
}
#endif