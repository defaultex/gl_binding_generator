#if (GL_OES_texture_border_clamp && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_BORDER_COLOR_OES = 0x1004;
        public const GLenum GL_CLAMP_TO_BORDER_OES = 0x812D;
    }
}
#endif