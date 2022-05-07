#if (GL_EXT_blend_color && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CONSTANT_COLOR_EXT = 0x8001;
        public const GLenum GL_ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
        public const GLenum GL_CONSTANT_ALPHA_EXT = 0x8003;
        public const GLenum GL_ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
        public const GLenum GL_BLEND_COLOR_EXT = 0x8005;
    }
}
#endif