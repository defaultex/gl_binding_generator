#if (GL_OES_blend_func_separate && !gles1)
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_BLEND_DST_RGB_OES = 0x80C8;
        public const GLenum GL_BLEND_SRC_RGB_OES = 0x80C9;
        public const GLenum GL_BLEND_DST_ALPHA_OES = 0x80CA;
        public const GLenum GL_BLEND_SRC_ALPHA_OES = 0x80CB;
    }
}
#endif