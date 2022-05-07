#if (GL_APPLE_texture_format_BGRA8888 && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_BGRA_EXT = 0x80E1;
        public const GLenum GL_BGRA8_EXT = 0x93A1;
    }
}
#endif