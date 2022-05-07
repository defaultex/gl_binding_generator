#if (GL_NV_light_max_exponent && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_SHININESS_NV = 0x8504;
        public const GLenum GL_MAX_SPOT_EXPONENT_NV = 0x8505;
    }
}
#endif