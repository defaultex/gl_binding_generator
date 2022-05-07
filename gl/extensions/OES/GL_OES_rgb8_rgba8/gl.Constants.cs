#if (GL_OES_rgb8_rgba8 && (!gles1 || !gles2 || !glsc2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_RGB8_OES = 0x8051;
        public const GLenum GL_RGBA8_OES = 0x8058;
    }
}
#endif