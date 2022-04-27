#if (GL_IMG_framebuffer_downsample && GLES2_API)
public partial class glext_img { 
    public partial class Constants { 
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG = 0x913C;
        public const GLenum GL_NUM_DOWNSAMPLE_SCALES_IMG = 0x913D;
        public const GLenum GL_DOWNSAMPLE_SCALES_IMG = 0x913E;
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG = 0x913F;
    }
}
#endif