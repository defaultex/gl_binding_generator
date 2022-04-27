#if (GL_EXT_texture_compression_s3tc && (GL_API || GLCORE_API || GLES2_API || GLSC2_API))
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;
    }
}
#endif