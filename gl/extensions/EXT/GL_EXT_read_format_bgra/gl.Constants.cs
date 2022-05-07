#if (GL_EXT_read_format_bgra && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_BGRA_EXT = 0x80E1;
        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365;
        public const GLenum GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366;
    }
}
#endif