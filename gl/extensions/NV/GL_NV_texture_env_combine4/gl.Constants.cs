#if (GL_NV_texture_env_combine4 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMBINE4_NV = 0x8503;
        public const GLenum GL_SOURCE3_RGB_NV = 0x8583;
        public const GLenum GL_SOURCE3_ALPHA_NV = 0x858B;
        public const GLenum GL_OPERAND3_RGB_NV = 0x8593;
        public const GLenum GL_OPERAND3_ALPHA_NV = 0x859B;
    }
}
#endif