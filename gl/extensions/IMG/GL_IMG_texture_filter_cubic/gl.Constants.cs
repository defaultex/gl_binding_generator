#if (GL_IMG_texture_filter_cubic && GLES2_API)
public partial class glext_img { 
    public partial class Constants { 
        public const GLenum GL_CUBIC_IMG = 0x9139;
        public const GLenum GL_CUBIC_MIPMAP_NEAREST_IMG = 0x913A;
        public const GLenum GL_CUBIC_MIPMAP_LINEAR_IMG = 0x913B;
    }
}
#endif