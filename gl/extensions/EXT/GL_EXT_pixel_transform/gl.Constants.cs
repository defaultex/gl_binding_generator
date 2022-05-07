#if (GL_EXT_pixel_transform && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_TRANSFORM_2D_EXT = 0x8330;
        public const GLenum GL_PIXEL_MAG_FILTER_EXT = 0x8331;
        public const GLenum GL_PIXEL_MIN_FILTER_EXT = 0x8332;
        public const GLenum GL_PIXEL_CUBIC_WEIGHT_EXT = 0x8333;
        public const GLenum GL_CUBIC_EXT = 0x8334;
        public const GLenum GL_AVERAGE_EXT = 0x8335;
        public const GLenum GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
        public const GLenum GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
        public const GLenum GL_PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;
    }
}
#endif