#if (GL_EXT_texture_compression_s3tc_srgb && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
#endif
    }
}
#endif