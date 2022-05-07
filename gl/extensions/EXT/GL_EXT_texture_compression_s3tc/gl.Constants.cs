#if (GL_EXT_texture_compression_s3tc && (!gl || !glcore || !gles2 || !glsc2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;
    }
}
#endif