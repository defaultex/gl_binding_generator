#if (GL_EXT_blend_func_extended && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_SRC_ALPHA_SATURATE_EXT = 0x0308;
        public const GLenum GL_SRC1_ALPHA_EXT = 0x8589;
        public const GLenum GL_SRC1_COLOR_EXT = 0x88F9;
        public const GLenum GL_ONE_MINUS_SRC1_COLOR_EXT = 0x88FA;
        public const GLenum GL_ONE_MINUS_SRC1_ALPHA_EXT = 0x88FB;
        public const GLenum GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT = 0x88FC;
        public const GLenum GL_LOCATION_INDEX_EXT = 0x930F;
    }
}
#endif