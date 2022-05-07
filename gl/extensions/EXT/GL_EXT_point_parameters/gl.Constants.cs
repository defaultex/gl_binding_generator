#if (GL_EXT_point_parameters && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POINT_SIZE_MIN_EXT = 0x8126;
        public const GLenum GL_POINT_SIZE_MAX_EXT = 0x8127;
        public const GLenum GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128;
        public const GLenum GL_DISTANCE_ATTENUATION_EXT = 0x8129;
    }
}
#endif