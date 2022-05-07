#if (GL_APPLE_ycbcr_422 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_YCBCR_422_APPLE = 0x85B9;
        public const GLenum GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
        public const GLenum GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
    }
}
#endif