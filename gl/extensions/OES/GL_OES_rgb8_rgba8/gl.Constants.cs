#if (GL_OES_rgb8_rgba8 && (GLES1_API || GLES2_API || GLSC2_API))
public partial class glext_oes { 
    public partial class Constants { 
        public const GLenum GL_RGB8_OES = 0x8051;
        public const GLenum GL_RGBA8_OES = 0x8058;
    }
}
#endif