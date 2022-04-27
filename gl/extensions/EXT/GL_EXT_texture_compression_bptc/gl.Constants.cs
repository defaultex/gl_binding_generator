#if (GL_EXT_texture_compression_bptc && GLES2_API)
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_RGBA_BPTC_UNORM_EXT = 0x8E8C;
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT = 0x8E8D;
        public const GLenum GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT = 0x8E8E;
        public const GLenum GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT = 0x8E8F;
    }
}
#endif