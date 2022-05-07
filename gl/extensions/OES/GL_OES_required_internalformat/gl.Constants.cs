#if (GL_OES_required_internalformat && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_ALPHA8_OES = 0x803C;
        public const GLenum GL_LUMINANCE8_OES = 0x8040;
        public const GLenum GL_LUMINANCE4_ALPHA4_OES = 0x8043;
        public const GLenum GL_LUMINANCE8_ALPHA8_OES = 0x8045;
        public const GLenum GL_RGB8_OES = 0x8051;
        public const GLenum GL_RGB10_EXT = 0x8052;
        public const GLenum GL_RGBA4_OES = 0x8056;
        public const GLenum GL_RGB5_A1_OES = 0x8057;
        public const GLenum GL_RGBA8_OES = 0x8058;
        public const GLenum GL_RGB10_A2_EXT = 0x8059;
        public const GLenum GL_DEPTH_COMPONENT16_OES = 0x81A5;
        public const GLenum GL_DEPTH_COMPONENT24_OES = 0x81A6;
        public const GLenum GL_DEPTH_COMPONENT32_OES = 0x81A7;
        public const GLenum GL_DEPTH24_STENCIL8_OES = 0x88F0;
        public const GLenum GL_RGB565_OES = 0x8D62;
    }
}
#endif