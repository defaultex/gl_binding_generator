#if (GL_IMG_texture_compression_pvrtc2 && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG = 0x9137;
        public const GLenum GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG = 0x9138;
    }
}
#endif