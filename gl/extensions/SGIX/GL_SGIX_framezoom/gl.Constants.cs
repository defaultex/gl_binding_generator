#if (GL_SGIX_framezoom && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAMEZOOM_SGIX = 0x818B;
        public const GLenum GL_FRAMEZOOM_FACTOR_SGIX = 0x818C;
        public const GLenum GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D;
    }
}
#endif