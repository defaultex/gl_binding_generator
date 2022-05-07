#if (GL_EXT_packed_pixels && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032;
        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033;
        public const GLenum GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034;
        public const GLenum GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035;
        public const GLenum GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036;
    }
}
#endif