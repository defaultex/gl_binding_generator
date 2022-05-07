#if (GL_INGR_color_clamp && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RED_MIN_CLAMP_INGR = 0x8560;
        public const GLenum GL_GREEN_MIN_CLAMP_INGR = 0x8561;
        public const GLenum GL_BLUE_MIN_CLAMP_INGR = 0x8562;
        public const GLenum GL_ALPHA_MIN_CLAMP_INGR = 0x8563;
        public const GLenum GL_RED_MAX_CLAMP_INGR = 0x8564;
        public const GLenum GL_GREEN_MAX_CLAMP_INGR = 0x8565;
        public const GLenum GL_BLUE_MAX_CLAMP_INGR = 0x8566;
        public const GLenum GL_ALPHA_MAX_CLAMP_INGR = 0x8567;
    }
}
#endif