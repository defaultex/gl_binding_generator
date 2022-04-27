#if (GL_EXT_texture_compression_dxt1 && (GLES1_API || GLES2_API))
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
        public const GLenum GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
    }
}
#endif