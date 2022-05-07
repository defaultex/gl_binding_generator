#if (GL_EXT_cmyka && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CMYK_EXT = 0x800C;
        public const GLenum GL_CMYKA_EXT = 0x800D;
        public const GLenum GL_PACK_CMYK_HINT_EXT = 0x800E;
        public const GLenum GL_UNPACK_CMYK_HINT_EXT = 0x800F;
    }
}
#endif