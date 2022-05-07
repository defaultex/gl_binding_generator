#if (GL_EXT_texture_compression_s3tc_srgb && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
    }
}
#endif