#if (GL_ARB_point_parameters && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POINT_SIZE_MIN_ARB = 0x8126;
        public const GLenum GL_POINT_SIZE_MAX_ARB = 0x8127;
        public const GLenum GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
        public const GLenum GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129;
    }
}
#endif