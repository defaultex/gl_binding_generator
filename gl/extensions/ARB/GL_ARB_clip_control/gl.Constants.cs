#if (GL_ARB_clip_control && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_LOWER_LEFT = 0x8CA1;
        public const GLenum GL_UPPER_LEFT = 0x8CA2;
        public const GLenum GL_CLIP_ORIGIN = 0x935C;
        public const GLenum GL_CLIP_DEPTH_MODE = 0x935D;
        public const GLenum GL_NEGATIVE_ONE_TO_ONE = 0x935E;
        public const GLenum GL_ZERO_TO_ONE = 0x935F;
    }
}
#endif