#if (GL_EXT_secondary_color && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COLOR_SUM_EXT = 0x8458;
        public const GLenum GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E;
    }
}
#endif