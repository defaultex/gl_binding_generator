#if (GL_EXT_window_rectangles && (GL_API || GLCORE_API || GLES2_API))
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_INCLUSIVE_EXT = 0x8F10;
        public const GLenum GL_EXCLUSIVE_EXT = 0x8F11;
        public const GLenum GL_WINDOW_RECTANGLE_EXT = 0x8F12;
        public const GLenum GL_WINDOW_RECTANGLE_MODE_EXT = 0x8F13;
        public const GLenum GL_MAX_WINDOW_RECTANGLES_EXT = 0x8F14;
        public const GLenum GL_NUM_WINDOW_RECTANGLES_EXT = 0x8F15;
    }
}
#endif