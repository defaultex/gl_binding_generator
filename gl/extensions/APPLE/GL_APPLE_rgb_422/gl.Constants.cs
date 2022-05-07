#if (GL_APPLE_rgb_422 && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
        public const GLenum GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
        public const GLenum GL_RGB_422_APPLE = 0x8A1F;
        public const GLenum GL_RGB_RAW_422_APPLE = 0x8A51;
    }
}
#endif