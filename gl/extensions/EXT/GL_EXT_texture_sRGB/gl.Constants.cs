#if (GL_EXT_texture_sRGB && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SRGB_EXT = 0x8C40;
        public const GLenum GL_SRGB8_EXT = 0x8C41;
        public const GLenum GL_SRGB_ALPHA_EXT = 0x8C42;
        public const GLenum GL_SRGB8_ALPHA8_EXT = 0x8C43;
        public const GLenum GL_SLUMINANCE_ALPHA_EXT = 0x8C44;
        public const GLenum GL_SLUMINANCE8_ALPHA8_EXT = 0x8C45;
        public const GLenum GL_SLUMINANCE_EXT = 0x8C46;
        public const GLenum GL_SLUMINANCE8_EXT = 0x8C47;
        public const GLenum GL_COMPRESSED_SRGB_EXT = 0x8C48;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_EXT = 0x8C49;
        public const GLenum GL_COMPRESSED_SLUMINANCE_EXT = 0x8C4A;
        public const GLenum GL_COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;
        public const GLenum GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
    }
}
#endif