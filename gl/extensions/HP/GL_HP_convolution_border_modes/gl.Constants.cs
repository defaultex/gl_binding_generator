#if (GL_HP_convolution_border_modes && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_IGNORE_BORDER_HP = 0x8150;
        public const GLenum GL_CONSTANT_BORDER_HP = 0x8151;
        public const GLenum GL_REPLICATE_BORDER_HP = 0x8153;
        public const GLenum GL_CONVOLUTION_BORDER_COLOR_HP = 0x8154;
    }
}
#endif