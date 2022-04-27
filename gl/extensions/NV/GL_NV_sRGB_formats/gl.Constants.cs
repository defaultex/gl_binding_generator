#if (GL_NV_sRGB_formats && GLES2_API)
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_ETC1_SRGB8_NV = 0x88EE;
        public const GLenum GL_SRGB8_NV = 0x8C41;
        public const GLenum GL_SLUMINANCE_ALPHA_NV = 0x8C44;
        public const GLenum GL_SLUMINANCE8_ALPHA8_NV = 0x8C45;
        public const GLenum GL_SLUMINANCE_NV = 0x8C46;
        public const GLenum GL_SLUMINANCE8_NV = 0x8C47;
        public const GLenum GL_COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV = 0x8C4D;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV = 0x8C4E;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV = 0x8C4F;
    }
}
#endif