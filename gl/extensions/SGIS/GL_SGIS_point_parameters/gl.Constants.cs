#if (GL_SGIS_point_parameters && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POINT_SIZE_MIN_SGIS = 0x8126;
        public const GLenum GL_POINT_SIZE_MAX_SGIS = 0x8127;
        public const GLenum GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128;
        public const GLenum GL_DISTANCE_ATTENUATION_SGIS = 0x8129;
    }
}
#endif