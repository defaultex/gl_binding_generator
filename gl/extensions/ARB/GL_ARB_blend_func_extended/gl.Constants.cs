#if (GL_ARB_blend_func_extended && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SRC1_ALPHA = 0x8589;
        public const GLenum GL_SRC1_COLOR = 0x88F9;
        public const GLenum GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
        public const GLenum GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
        public const GLenum GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
    }
}
#endif