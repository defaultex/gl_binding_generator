#if (GL_EXT_texture_compression_latc && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;
        public const GLenum GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;
        public const GLenum GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;
        public const GLenum GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;
    }
}
#endif