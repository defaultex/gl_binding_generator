#if (GL_EXT_422_pixels && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_422_EXT = 0x80CC;
        public const GLenum GL_422_REV_EXT = 0x80CD;
        public const GLenum GL_422_AVERAGE_EXT = 0x80CE;
        public const GLenum GL_422_REV_AVERAGE_EXT = 0x80CF;
    }
}
#endif