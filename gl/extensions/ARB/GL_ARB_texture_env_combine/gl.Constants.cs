#if (GL_ARB_texture_env_combine && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SUBTRACT_ARB = 0x84E7;
        public const GLenum GL_COMBINE_ARB = 0x8570;
        public const GLenum GL_COMBINE_RGB_ARB = 0x8571;
        public const GLenum GL_COMBINE_ALPHA_ARB = 0x8572;
        public const GLenum GL_RGB_SCALE_ARB = 0x8573;
        public const GLenum GL_ADD_SIGNED_ARB = 0x8574;
        public const GLenum GL_INTERPOLATE_ARB = 0x8575;
        public const GLenum GL_CONSTANT_ARB = 0x8576;
        public const GLenum GL_PRIMARY_COLOR_ARB = 0x8577;
        public const GLenum GL_PREVIOUS_ARB = 0x8578;
        public const GLenum GL_SOURCE0_RGB_ARB = 0x8580;
        public const GLenum GL_SOURCE1_RGB_ARB = 0x8581;
        public const GLenum GL_SOURCE2_RGB_ARB = 0x8582;
        public const GLenum GL_SOURCE0_ALPHA_ARB = 0x8588;
        public const GLenum GL_SOURCE1_ALPHA_ARB = 0x8589;
        public const GLenum GL_SOURCE2_ALPHA_ARB = 0x858A;
        public const GLenum GL_OPERAND0_RGB_ARB = 0x8590;
        public const GLenum GL_OPERAND1_RGB_ARB = 0x8591;
        public const GLenum GL_OPERAND2_RGB_ARB = 0x8592;
        public const GLenum GL_OPERAND0_ALPHA_ARB = 0x8598;
        public const GLenum GL_OPERAND1_ALPHA_ARB = 0x8599;
        public const GLenum GL_OPERAND2_ALPHA_ARB = 0x859A;
    }
}
#endif