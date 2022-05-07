#if (GL_EXT_pvrtc_sRGB && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT = 0x8A54;
        public const GLenum GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT = 0x8A55;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT = 0x8A56;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT = 0x8A57;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG = 0x93F0;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG = 0x93F1;
    }
}
#endif